using SmartFood.Core.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core.Serialisation
{
    public class OrderStatusesCore: CoreBase
    {
        private static OrderStatuses orderStatuses = null;
        public static OrderStatuses OrderStatuses
        {
            get
            {
                if (orderStatuses == null)
                    GetOrderStatuses();
                return orderStatuses;
            }
        }

        public static bool GetOrderStatuses()
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.GET);
            return SendGetRequest<OrderStatuses>(UriPostfix.ORDER_STATUSES, param, out orderStatuses);
        }
    }
}
