using SmartFood.Core.Constants;
using SmartFood.Core.Serialisation;
using System.Collections.Generic;

namespace SmartFood.Core
{
    public class ConsumblesTypesCore: CoreBase
    {
        private static ConsumbleTypes consumbleTypes = null;
        public static ConsumbleTypes ConsumbleTypes
        {
            get
            {
                if (consumbleTypes == null)
                    GetConsumbleTypes();
                return consumbleTypes;
            }
        }

        public static bool GetConsumbleTypes()
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.GET);
            return SendGetRequest<ConsumbleTypes>(UriPostfix.CONSUMBLE_TYPES, param, out consumbleTypes);            
        }

        public static bool AddConsumbleType(string name)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.ADD);
            param.Add(RequestFields.NAME, name);
            return SendEditRequest(UriPostfix.CONSUMBLE_TYPES, param);
        }

        public static bool EditConsumbleType(string id,string name,string visible)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.EDIT);
            param.Add(RequestFields.ID, id);
            param.Add(RequestFields.NAME, name);
            param.Add(RequestFields.VISIBLE, visible);
            return SendEditRequest(UriPostfix.CONSUMBLE_TYPES, param);
        }
    }
}
