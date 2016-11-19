using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core
{
    public class LoginCore : CoreBase
    {
        private static string uriPostfix = "auth/login/";
        public static void LogIn(long role, string login, string password)
        { 
            Dictionary<string,string> param = new Dictionary<string, string>();
            param.Add("type",role.ToString());
            param.Add("login", login);
            param.Add("pass", password);

            SendAuthRequest(uriPostfix, param);

        }
    }
}
