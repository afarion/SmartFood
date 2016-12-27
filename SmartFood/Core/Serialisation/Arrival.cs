using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core.Serialisation
{
    [Serializable]
    public class Arrivals
    {
        public int count;
        public List<Arrival> items;

        public Arrival GetArrival(int id)
        {
            foreach (Arrival arrival in items)
            {
                if (arrival.id == id)
                    return arrival;
            }

            return null;
        }
    }


    [Serializable]
    public class Arrival
    {
        public int id;
        public int id_item;
        public int id_provider;
        public int id_admin;
        public int id_employee;
        public double amount;
        public double price;
        public DateTime date_create;
    }
}
