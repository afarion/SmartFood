using SmartFood.Core.Serialisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Web.Script.Serialization;

namespace SmartFood.Core
{
    public class ConsumblesTypesCore: CoreBase
    {
        public static ConsumbleTypes consumbleTypes = null;
        private static Thread thread;

        public static void GetConsumbleTypes()
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("action", "view");
            bool isOK = SendRequest<ConsumbleTypes>(UriPostfix.CONSUMBLE_TYPES, param, out consumbleTypes);
            
        }

    }
}
