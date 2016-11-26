using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core
{
    [Serializable]
    public class AuthUserData
    {
        public long id;
        public int type;
        public string login;
        public string sid;
    }
}
