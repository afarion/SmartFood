using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Script.Serialization;
using System.Configuration;
using System.Windows.Forms;
using SmartFood.Core.Serialisation;
using SmartFood.Forms;

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

        public static bool SendRequest<T>(string uriPostfix, Dictionary<string, string> param, out T result)
        {
            try
            {
                param.Add("user_id", loggedUserID.ToString());
                param.Add("user_type", loggedUserTYPE.ToString());
                param.Add("user_sid", loggedUserSID.ToString());
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(apiUri + uriPostfix);
                FormUrlEncodedContent content = new FormUrlEncodedContent(param);
                HttpResponseMessage response = client.PostAsync(apiUri + uriPostfix, content).Result;
                string resultContent = response.Content.ReadAsStringAsync().Result;
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    result = new JavaScriptSerializer().Deserialize<T>(resultContent);
                    return true;
                }
                else
                {
                    ProcessErrors(response);
                    result = default(T);
                    return false;
                }
            }
            catch (Exception ex)
            {
                result = default(T);
                ErrorsViewWrapper.ShowError("Авторизация не удалась. Ошибка: " + ex.Message, "Ошибка");
                return false;                
            }
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
                    case System.Net.HttpStatusCode.Unauthorized://401
                        ErrorsViewWrapper.ShowError("С вашего аккаунта был выполнен вход с другого устройства. Приложение будет закрыто", "Ошибка авторизации");
                        Application.Exit();
                        break;
                    case System.Net.HttpStatusCode.Forbidden://403
                        ErrorsViewWrapper.ShowError("У вас нет прав для совершения этого действия", "Ошибка доступа");
                        break;
                    case System.Net.HttpStatusCode.NotFound://404
                        ErrorsViewWrapper.ShowError("Реквест не найден", "Ошибка");
                        break;
                    case System.Net.HttpStatusCode.BadRequest://400
                        ErrorsViewWrapper.ShowError("Ошибка входа. Проверьте правильность введенных данных и повторите попытку", "Ошибка");
                        break;
                    default:
                        throw new Exception("Неизвестный статус код ошмбки " + response.StatusCode);
                }
            }
            catch(Exception ex)
            {
                ErrorsViewWrapper.ShowError("Авторизация не удалась. Ошибка: " + ex.Message, "Ошибка");
            }         
        }

        private static void ProcessErrors(HttpResponseMessage response)
        {
            string resultContent = response.Content.ReadAsStringAsync().Result;
            switch (response.StatusCode)
            {
                case System.Net.HttpStatusCode.BadRequest: //400
                    ErrorType error = new JavaScriptSerializer().Deserialize<ErrorType>(resultContent);
                    ErrorsViewWrapper.ShowError(string.Format("Ошибка {0}: {1} "), "Неверный запрос");
                    break;
                case System.Net.HttpStatusCode.Unauthorized://401
                    ErrorsViewWrapper.ShowError("С вашего аккаунта был выполнен вход с другого устройства. Приложение будет закрыто", "Ошибка авторизации");
                    Application.Exit();
                    break;
                case System.Net.HttpStatusCode.Forbidden://403
                    ErrorsViewWrapper.ShowError("У вас нет прав для совершения этого действия", "Ошибка доступа");
                    break;
                case System.Net.HttpStatusCode.NotFound://404
                    ErrorsViewWrapper.ShowError("Реквест не найден", "Ошибка");
                    break;
                default:
                    throw new Exception("Неизвестный статус код ошмбки " + response.StatusCode);
            }
        }
    }
}
