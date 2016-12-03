using SmartFood.Core.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core
{
    public class LoginCore : CoreBase
    {
        public static void LogIn(long role, string login, string password)
        {
            Dictionary<string,string> param = new Dictionary<string, string>();
            param.Add(RequestFields.TYPE, role.ToString());
            param.Add(RequestFields.LOGIN, login);
            param.Add(RequestFields.PASSWORD, password);

            SendAuthRequest(UriPostfix.AUTHENTICATION, param);

        }
    }
}
