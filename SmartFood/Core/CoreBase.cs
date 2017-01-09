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
using SmartFood.Core.Constants;

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
            apiUri = ConfigurationManager.AppSettings[RequestFields.API_URI];
        }

        public static bool SendGetRequest<T>(string uriPostfix, Dictionary<string, string> param, out T result)
        {
            try
            {
                param.Add(RequestFields.USER_ID, loggedUserID.ToString());
                param.Add(RequestFields.USER_TYPE, loggedUserTYPE.ToString());
                param.Add(RequestFields.USER_SID, loggedUserSID.ToString());
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
                ErrorsViewWrapper.ShowError(ErrorTexts.ERROR + ex.Message);
                return false;                
            }
        }

        public static bool SendEditRequest(string uriPostfix, Dictionary<string, string> param)
        {
            try
            {
                param.Add(RequestFields.USER_ID, loggedUserID.ToString());
                param.Add(RequestFields.USER_TYPE, loggedUserTYPE.ToString());
                param.Add(RequestFields.USER_SID, loggedUserSID.ToString());
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(apiUri + uriPostfix);
                FormUrlEncodedContent content = new FormUrlEncodedContent(param);
                HttpResponseMessage response = client.PostAsync(apiUri + uriPostfix, content).Result;
                string resultContent = response.Content.ReadAsStringAsync().Result;
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return true;
                }
                else
                {
                    ProcessErrors(response);
                    return false;
                }
            }
            catch (Exception ex)
            {
                ErrorsViewWrapper.ShowError(ErrorTexts.ERROR + ex.Message);
                return false;
            }
        }

        public static int SendEditRequestID(string uriPostfix, Dictionary<string, string> param)
        {
            try
            {
                param.Add(RequestFields.USER_ID, loggedUserID.ToString());
                param.Add(RequestFields.USER_TYPE, loggedUserTYPE.ToString());
                param.Add(RequestFields.USER_SID, loggedUserSID.ToString());
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(apiUri + uriPostfix);
                FormUrlEncodedContent content = new FormUrlEncodedContent(param);
                HttpResponseMessage response = client.PostAsync(apiUri + uriPostfix, content).Result;
                string resultContent = response.Content.ReadAsStringAsync().Result;
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    ResultSuccess res = new JavaScriptSerializer().Deserialize<ResultSuccess>(resultContent);
                    return res.success;
                }
                else
                {
                    ProcessErrors(response);
                    return -1;
                }
            }
            catch (Exception ex)
            {
                ErrorsViewWrapper.ShowError(ErrorTexts.ERROR + ex.Message);
                return -1;
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
                        ErrorsViewWrapper.ShowError(ErrorTexts.ANOTHER_DEVICE_LOGGED, ErrorTexts.AUTORITHATION_FAILED);
                        Application.Exit();
                        break;
                    case System.Net.HttpStatusCode.Forbidden://403
                        ErrorsViewWrapper.ShowError(ErrorTexts.PERMISSIONS_DENIED, ErrorTexts.ACCESS_DENIED);
                        break;
                    case System.Net.HttpStatusCode.NotFound://404
                        ErrorsViewWrapper.ShowError(ErrorTexts.REQUEST_NOT_FOUND);
                        break;
                    case System.Net.HttpStatusCode.BadRequest://400
                        ErrorsViewWrapper.ShowError(ErrorTexts.INCORRECT_CREDENTIALS);
                        break;
                    default:
                        throw new Exception(ErrorTexts.UNKNOWN_STATUS_ERROR + response.StatusCode);
                }
            }
            catch(Exception ex)
            {
                ErrorsViewWrapper.ShowError(ErrorTexts.AUTHORITHATION_NOT_SUCCEDED + ex.Message);
            }         
        }

        private static void ProcessErrors(HttpResponseMessage response)
        {
            string resultContent = response.Content.ReadAsStringAsync().Result;
            switch (response.StatusCode)
            {
                case System.Net.HttpStatusCode.BadRequest: //400
                    ErrorType error = new JavaScriptSerializer().Deserialize<ErrorType>(resultContent);
                    ErrorsViewWrapper.ShowError(string.Format(ErrorTexts.ERROR_EX, error.code, error.message), ErrorTexts.INCORRECT_REQUEST);
                    break;
                case System.Net.HttpStatusCode.Unauthorized://401
                    ErrorsViewWrapper.ShowError(ErrorTexts.ANOTHER_DEVICE_LOGGED, ErrorTexts.AUTHORITHATION_FAILED);
                    Application.Exit();
                    break;
                case System.Net.HttpStatusCode.Forbidden://403
                    ErrorsViewWrapper.ShowError(ErrorTexts.PERMISSIONS_DENIED, ErrorTexts.ACCESS_DENIED);
                    break;
                case System.Net.HttpStatusCode.NotFound://404
                    ErrorsViewWrapper.ShowError(ErrorTexts.REQUEST_NOT_FOUND);
                    break;
                default:
                    throw new Exception(ErrorTexts.UNKNOWN_STATUS_ERROR + response.StatusCode);
            }
        }
    }
}
