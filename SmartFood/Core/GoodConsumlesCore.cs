using SmartFood.Core.Constants;
using SmartFood.Core.Serialisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core
{
    public class GoodConsumlesCore:CoreBase
    {
        public static GoodConsumbles GetGoodConsumles(int goodId)
        {
            GoodConsumbles goodConsumbles = null;
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.GET);
            param.Add(RequestFields.GOOD_ID, goodId.ToString());
            SendGetRequest<GoodConsumbles>(UriPostfix.GOOD_CONSUMBLES, param, out goodConsumbles);
            return goodConsumbles;
        }

        public static bool AddGoodConsumle(int goodId, int consumbleID, double weight)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.ADD);
            param.Add(RequestFields.GOOD_ID, goodId.ToString());
            param.Add(RequestFields.CONSUMBLE_ID, consumbleID.ToString());
            param.Add(RequestFields.WEIGHT, weight.ToString());
            return SendEditRequest(UriPostfix.GOOD_CONSUMBLES, param);
        }

        public static bool EditGoodConsumle(int id, double weight, int visible)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.EDIT);
            param.Add(RequestFields.ID, id.ToString());
            param.Add(RequestFields.WEIGHT, weight.ToString());
            param.Add(RequestFields.VISIBLE, visible.ToString());
            return SendEditRequest(UriPostfix.GOOD_CONSUMBLES, param);
        }

        public static bool RemoveGoodConsumle(int id)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.REMOVE);
            param.Add(RequestFields.ID, id.ToString());
            return SendEditRequest(UriPostfix.GOOD_CONSUMBLES, param);
        }
    }
}
