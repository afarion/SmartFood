using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core.Serialisation
{
    [Serializable]
    public class ClientAddresses
    {
        public int count;
        public List<ClientAddress> items;

        public List<string> ToList()
        {
            List<string> tmpList = new List<string>();
            foreach (var item in items)
            {
                tmpList.Add(item.address);
            }
            return tmpList;
        }

        public int GetID(string address)
        {
            foreach (var item in items)
            {
                if (item.address == address)
                    return item.id;
            }
            return -1;
        }

        public string GetAddress(int id)
        {
            foreach (var item in items)
            {
                if (item.id == id)
                    return item.address;
            }
            return string.Empty;
        }
    }

    [Serializable]
    public class ClientAddress
    {
        public int id;
        public string address;
    }
}
