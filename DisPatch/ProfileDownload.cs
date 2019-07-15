using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace DisPatch
{
   static class ProfileDownload
    {

        public static async void DownloadPageAsync()
        {
            string URL = "https://dannyraviii.pythonanywhere.com/bip/profile/1/";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.ContentType = "application/json; charset=utf-8";
            request.Headers["Authorization"] = "Token 5e95ee2a97d212e9080d7079149073b1a2ae4d7b";
            request.PreAuthenticate = true;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            using (Stream responseStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);

                string json = string.Empty;
                string sson = string.Empty;
                json = reader.ReadToEnd();
                var res = JsonConvert.DeserializeObject<dynamic>(json);
            //    DataDownload dd = new DataDownload();
                string first_name_ = res.first_name;
                string last_name_ = res.first_name;
                string phone_number_ = res.first_name;
                string mobile_number_ = res.first_name;
                string age_ = res.first_name;
                string group_ = res.first_name;
                string nation_code_ = res.first_name;
                string height_ = res.first_name;
                string weigth_ = res.first_name;
                string address_ = res.first_name;
                string postal_code_ = res.first_name;
                string email_ = res.first_name;
                string gender_ = res.first_name;
                string user_ = res.first_name;

            }
        }
    }
}
