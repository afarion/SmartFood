using SmartFood.Core.Constants;
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
            param.Add(RequestFields.ACTION, Actions.GET);
            param.Add(RequestFields.TYPE, consumbleTypeID);
            return SendGetRequest<ConsumbleCategories>(UriPostfix.CONSUMBLE_CATEGORIES, param, out consumbleCategories);
        }

        public static bool AddConsumbleCategorie(string name, long consumbleTypeID)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.ADD);
            param.Add(RequestFields.ID_TYPE, consumbleTypeID.ToString());
            param.Add(RequestFields.NAME, name);
            return SendEditRequest(UriPostfix.CONSUMBLE_CATEGORIES, param);
        }

        public static bool EditConsumbleCategorie(string id, string name, string visible, long consumbleTypeID)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.EDIT);
            param.Add(RequestFields.ID_TYPE, consumbleTypeID.ToString());
            param.Add(RequestFields.ID, id);
            param.Add(RequestFields.NAME, name);
            param.Add(RequestFields.VISIBLE, visible);
            return SendEditRequest(UriPostfix.CONSUMBLE_CATEGORIES, param);
        }

        public static ConsumbleCategories GetAllExistingCategories()
        {
            List<ConsumbleCategorie> allCategories = new List<ConsumbleCategorie>();
            ConsumbleCategories tmp = null;
            foreach (var type in ConsumblesTypesCore.ConsumbleTypes.items)
            {
                Dictionary<string, string> param = new Dictionary<string, string>();
                param.Add(RequestFields.ACTION, Actions.GET);
                param.Add(RequestFields.TYPE, type.id.ToString());
                SendGetRequest<ConsumbleCategories>(UriPostfix.CONSUMBLE_CATEGORIES, param, out tmp);
                allCategories.AddRange(tmp.items);
            }
            tmp = new Serialisation.ConsumbleCategories();
            tmp.items = allCategories;
            return tmp;
        }
    }
}
