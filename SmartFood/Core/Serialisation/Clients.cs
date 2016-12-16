using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core.Serialisation
{
    [Serializable]
    public class Clients
    {
        public List<Client> items;
        public int count;
        public List<string> ToList()
        {
            List<string> tmpList = new List<string>();
            foreach (var item in items)
            {
                tmpList.Add(item.name);
            }
            return tmpList;
        }

        public int GetID(string name)
        {
            foreach (var item in items)
            {
                if (item.name == name)
                    return item.id;
            }
            return -1;
        }

        public string GetName(int id)
        {
            foreach (var item in items)
            {
                if (item.id == id)
                    return item.name;
            }
            return string.Empty;
        }

        public List<string> GetAddresses(int id)
        {
            foreach (var item in items)
            {
                if (item.id == id)
                    return item.addresses.ToList();
            }
            return null;
        }

        public Client GetClint(int id)
        {
            foreach (var item in items)
            {
                if (item.id == id)
                    return item;
            }
            return null;
        }
    }

    [Serializable]
    public class Client
    {
        public int id;
        public string name;
        public string phone;
        public string email;
        public int discount_fixed;
        public int discount_stored;
        public double total_balance;
        public string comment;
        public string discount_reason;
        public int visible;
        [NonSerialized]
        public ClientAddresses addresses;
    }
}
