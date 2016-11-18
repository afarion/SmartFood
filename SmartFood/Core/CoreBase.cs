using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Script.Serialization;

namespace SmartFood.Core
{
    public class CoreBase
    {
        public static string apiURI;
        protected static Dictionary<string, string> param;
        public static string SendRequest()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(apiURI);
            FormUrlEncodedContent content = new FormUrlEncodedContent(param);
            var response =  client.PostAsync(apiURI, content).Result;
            string resultContent = response.Content.ReadAsStringAsync().Result;
            return resultContent;
        }
    }
}
