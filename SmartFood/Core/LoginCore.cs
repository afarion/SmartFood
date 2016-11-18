using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core
{
    public class LoginCore : CoreBase
    {
        public static void LogIn()
        {
            apiURI = "http://195.138.83.164:8080/v1/auth/login/";
            param = new Dictionary<string, string>();
            param.Add("type","1");
            param.Add("login", "admin");
            param.Add("pass", "admin");
            string message = SendRequest();
        }
    }
}
