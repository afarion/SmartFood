using SmartFood.Core.Constants;
using SmartFood.Core.Serialisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core
{
    public class ConsumblesCore : CoreBase
    {
        private static Consumbles consumbles = null;
        public static Consumbles Consumbles
        {
            get
            {
                if (consumbles == null)
                    GetConsumbles();
                return consumbles;
            }
        }
        public static bool GetConsumbles()
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.GET);
            return SendGetRequest<Consumbles>(UriPostfix.CONSUMBLES, param, out consumbles);
        }

        public static bool AddConsumble(string name, int idType, int idCategory, int idMeasure, double amount, double price)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.ADD);
            param.Add(RequestFields.NAME, name);
            param.Add(RequestFields.ID_TYPE, idType.ToString());
            param.Add(RequestFields.ID_CATEGORY, idCategory.ToString());
            param.Add(RequestFields.ID_MEASURE, idMeasure.ToString());
            param.Add(RequestFields.AMOUNT, amount.ToString());
            param.Add(RequestFields.PRICE, price.ToString());
            return SendEditRequest(UriPostfix.CONSUMBLES, param);
        }

        public static bool EditConsumble(string id, string name, string visible, int idType, int idCategory, int idMeasure)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.EDIT);
            param.Add(RequestFields.ID, id);
            param.Add(RequestFields.NAME, name);
            param.Add(RequestFields.VISIBLE, visible);
            param.Add(RequestFields.ID_TYPE, idType.ToString());
            param.Add(RequestFields.ID_CATEGORY, idCategory.ToString());
            param.Add(RequestFields.ID_MEASURE, idMeasure.ToString());
            return SendEditRequest(UriPostfix.CONSUMBLES, param);
        }
    }
}
