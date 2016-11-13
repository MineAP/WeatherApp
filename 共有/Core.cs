using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SharedLib
{
    public class Core
    {
        public static async Task<Weather> GetWeather(string zipCode)
        {

            zipCode = zipCode.Insert(3, "-");

            string queryString = "http://api.openweathermap.org/data/2.5/forecast/city?zip=" + zipCode + ",JP&APPID=03a686f9a51b5b03aeade33f5162cdcf";
            JContainer result = await DataService.getDataFromService(queryString).ConfigureAwait(false);

            if (result["city"] != null)
            {
                try
                {
                    Weather weather = new Weather();

                    JContainer city = (JContainer)result["city"];
                    //weather.Title = city["name"] + "," + city["country"];
                    weather.Title = ((string)city["name"]) + "," + ((string)city["country"]);

                    JContainer main = (JContainer)result["list"][0]["main"];
                    double temp = (double)main["temp"];
                    temp = temp - 273.15;
                    weather.Temperature = temp.ToString();

                    JContainer wind = (JContainer)result["list"][0]["wind"];
                    weather.Wind = (string)wind["speed"];
                    
                    weather.Humidity = (string)main["humidity"];
                    weather.Visibility = "(no data)";
                    
                    weather.Sunrise = "(no data)";
                    weather.Sunset = "(no data)";

                    return weather;

                }catch (Exception e)
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
