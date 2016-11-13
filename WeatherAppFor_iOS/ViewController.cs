using System;

using UIKit;

using SharedLib;


namespace WeatherAppFor_iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void GetWeatherButton_TouchUpInside(UIButton sender)
        {

            Weather w = Core.GetWeather(TextZipCodeEdit.Text).Result;
            
            if (w != null)
            {
                titleLabel.Text = w.Title;
                TempLabel.Text = w.Temperature;
                WindLabel.Text = w.Wind;
                //visibilityLabel.Text = w.Visibility;
                HumidityLabel.Text = w.Humidity;
                //SunriseText.Text = w.Sunrise;
                //SunsetText.Text = w.Sunset;

                GetWeatherButton.TitleLabel.Text = "Search Again";
            }
            else
            {
                titleLabel.Text = "Couldn't find any results";
            }
        }
    }
}