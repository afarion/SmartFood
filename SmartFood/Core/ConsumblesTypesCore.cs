using SmartFood.Core.Serialisation;
using System.Collections.Generic;

namespace SmartFood.Core
{
    public class ConsumblesTypesCore: CoreBase
    {
        public static ConsumbleTypes consumbleTypes = null;

        public static bool GetConsumbleTypes()
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("action", "view");
            return SendGetRequest<ConsumbleTypes>(UriPostfix.CONSUMBLE_TYPES, param, out consumbleTypes);            
        }

        public static bool AddConsumbleType(string name)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("action", "add");
            param.Add("name", name);
            return SendEditRequest(UriPostfix.CONSUMBLE_TYPES, param);
        }

        public static bool EditConsumbleType(string id,string name,string visible)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("action", "edit");
            param.Add("id", id);
            param.Add("name", name);
            param.Add("visible", visible);
            return SendEditRequest(UriPostfix.CONSUMBLE_TYPES, param);
        }

    }
}
