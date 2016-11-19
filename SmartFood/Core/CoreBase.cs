using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Script.Serialization;
using System.Configuration;
using System.Windows.Forms;

namespace SmartFood.Core
{
    public class CoreBase
    {
        private static long loggedUserID;
        private static string loggedUserSID = string.Empty;
        private static int loggedUserTYPE;
        private static string apiUri = null;
        public static bool isAuthorised = false;

        public static void Init()
        {
            apiUri = ConfigurationManager.AppSettings["ApiUri"];
        }

        public static string SendRequest(string uriPostfix, Dictionary<string, string> param)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri (apiUri + uriPostfix);
            FormUrlEncodedContent content = new FormUrlEncodedContent(param);
            var response =  client.PostAsync(apiUri + uriPostfix, content).Result;
            string resultContent = response.Content.ReadAsStringAsync().Result;
            return resultContent;
        }

        public static void SendAuthRequest(string uriPostfix, Dictionary<string, string> param)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(apiUri + uriPostfix);
                FormUrlEncodedContent content = new FormUrlEncodedContent(param);
                var response = client.PostAsync(apiUri + uriPostfix, content).Result;
                string resultContent = response.Content.ReadAsStringAsync().Result;

                switch (response.StatusCode)
                {
                    case System.Net.HttpStatusCode.OK:
                        isAuthorised = true;
                        AuthUserData data = new JavaScriptSerializer().Deserialize<AuthUserData>(resultContent);
                        loggedUserID = data.id;
                        loggedUserSID = data.sid;
                        loggedUserTYPE = data.type;
                        break;
                    default:
                        throw new Exception("Неизвестный статус код ошмбки " + response.StatusCode);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Авторизация не удалась. Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }
    }
}
