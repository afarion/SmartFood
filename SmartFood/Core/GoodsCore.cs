using SmartFood.Core.Constants;
using SmartFood.Core.Serialisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core
{
    public class GoodsCore: CoreBase
    {
        private static Goods goods = null;
        public static Goods Goods
        {
            get
            {
                if (goods == null)
                    GetGoods();
                return goods;
            }
        }

        public static bool GetGoods()
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.GET);
            bool isOk = SendGetRequest<Goods>(UriPostfix.GOODS, param, out goods);
            foreach (Good good in goods.items)
                good.consumbles = GoodConsumlesCore.GetGoodConsumles(good.id);

            return isOk;
        }

        public static bool AddGood(string name, int id_category, double weight, double price)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.ADD);
            param.Add(RequestFields.NAME, name);
            param.Add(RequestFields.ID_CATEGORY, id_category.ToString());
            param.Add(RequestFields.WEIGHT, weight.ToString());
            param.Add(RequestFields.PRICE, price.ToString());
            return SendEditRequest(UriPostfix.GOODS, param);
        }

        public static bool EditGood(int id,string name, int id_category, double weight, double price, int visible)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.EDIT);
            param.Add(RequestFields.ID, id.ToString());
            param.Add(RequestFields.NAME, name);
            param.Add(RequestFields.ID_CATEGORY, id_category.ToString());
            param.Add(RequestFields.WEIGHT, weight.ToString());
            param.Add(RequestFields.PRICE, price.ToString());
            param.Add(RequestFields.VISIBLE, visible.ToString());
            return SendEditRequest(UriPostfix.GOODS, param);
        }
    }
}
