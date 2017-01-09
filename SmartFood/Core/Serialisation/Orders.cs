using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core.Serialisation
{
    [Serializable]
    public class Orders
    {
        public int count;
        public List<Order> items;
    }
    [Serializable]
    public class Order
    {
        public int id;
        public int id_user;
        public int id_admin;
        public int id_courier;
        public int id_status;
        public double price;
        public int discount;
        public double result_price;
        public int pickup;
        public DateTime deliver_on_time;
        public string address;
        public DateTime date_create;
        public DateTime date_compleate;
        public DateTime date_pay;
        public int visible;
    }
}
