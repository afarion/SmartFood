using SmartFood.Core.Constants;
using SmartFood.Core.Serialisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core
{
    public class OrderCore: CoreBase
    {
        private static Orders orders = null;
        public static Orders Orders
        {
            get
            {
                if (orders == null)
                    GetOrders(DateTime.Today);
                return orders;
            }
        }

        public static bool GetOrders(DateTime date_from)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.GET);
            param.Add(RequestFields.DATE_FROM, date_from.ToString("yyyy-MM-dd"));
            return SendGetRequest<Orders>(UriPostfix.ORDERS, param, out orders);
        }

        public static int AddOrder(int id_user, int id_courier, int pickup, DateTime deliver_on_time, string address)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.ADD);
            param.Add(RequestFields.CLIENT_ID, id_user.ToString());
            param.Add(RequestFields.COURIER_ID, id_courier.ToString());
            param.Add(RequestFields.PICKUP, pickup.ToString());
            param.Add(RequestFields.DELIVER_ON_TIME, deliver_on_time.ToString("yyyy-MM-dd hh:mm:ss"));
            param.Add(RequestFields.ADDRESS, address);
            return SendEditRequestID(UriPostfix.ORDERS, param);
        }

        public static int EditOrder(int id, int id_user, int id_courier, int pickup, DateTime deliver_on_time, string address, int visible)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.EDIT);
            param.Add(RequestFields.ID, id.ToString());
            param.Add(RequestFields.CLIENT_ID, id_user.ToString());
            param.Add(RequestFields.COURIER_ID, id_courier.ToString());
            param.Add(RequestFields.PICKUP, pickup.ToString());
            param.Add(RequestFields.DELIVER_ON_TIME, deliver_on_time.ToString("yyyy-MM-dd hh:mm:ss"));
            param.Add(RequestFields.ADDRESS, address);
            param.Add(RequestFields.VISIBLE, visible.ToString());
            return SendEditRequestID(UriPostfix.ORDERS, param);
        }
    }
}
