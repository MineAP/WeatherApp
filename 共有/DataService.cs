using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SharedLib
{
    public class DataService
    {

        /// <summary>
        /// 指定されたクエリストリングを使用してHTTPに対してGETリクエストを行い、得られた応答を返します。
        /// </summary>
        /// <param name="queryString"></param>
        /// <returns></returns>
        public static async Task<dynamic> getDataFromService(string queryString)
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(queryString);

            WebResponse response = await request.GetResponseAsync().ConfigureAwait(false);
            Stream stream = response.GetResponseStream();

            StreamReader streamReader = new StreamReader(stream);
            string responseText = streamReader.ReadToEnd();

            dynamic data = JsonConvert.DeserializeObject(responseText);

            return data;

        }
        
    }
}
