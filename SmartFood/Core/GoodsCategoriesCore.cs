using SmartFood.Core.Constants;
using SmartFood.Core.Serialisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core
{
    public class GoodsCategoriesCore: CoreBase
    {
        private static GoodsCategories goodsCategories = null;
        public static GoodsCategories GoodsCategories
        {
            get
            {
                if (goodsCategories == null)
                    GetGoodsCategories();
                return goodsCategories;
            }
        }

        public static bool GetGoodsCategories()
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.GET);
            return SendGetRequest<GoodsCategories>(UriPostfix.GOOD_CATEGORIES, param, out goodsCategories);
        }
    }
}
