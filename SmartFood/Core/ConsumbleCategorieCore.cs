using SmartFood.Core.Serialisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core
{
    public class ConsumbleCategorieCore : CoreBase
    {
        public static ConsumbleCategories consumbleCategories = null;

        public static bool GetConsumbleCategorie(string consumbleTypeID)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("action", "view");
            param.Add("type", consumbleTypeID);
            return SendGetRequest<ConsumbleCategories>(UriPostfix.CONSUMBLE_CATEGORIES, param, out consumbleCategories);
        }

        public static bool AddConsumbleCategorie(string name, long consumbleTypeID)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("action", "add");
            param.Add("id_type", consumbleTypeID.ToString());
            param.Add("name", name);
            return SendEditRequest(UriPostfix.CONSUMBLE_CATEGORIES, param);
        }

        public static bool EditConsumbleCategorie(string id, string name, string visible, long consumbleTypeID)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("action", "edit");
            param.Add("id_type", consumbleTypeID.ToString());
            param.Add("id", id);
            param.Add("name", name);
            param.Add("visible", visible);
            return SendEditRequest(UriPostfix.CONSUMBLE_CATEGORIES, param);
        }
    }
}
