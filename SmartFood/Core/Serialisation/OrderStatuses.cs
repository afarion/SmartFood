using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core.Serialisation
{
    [Serializable]
    public class OrderStatuses
    {
        public int count;
        public List<OrderStatus> items;

        public List<string> ToList()
        {
            List<string> tmpList = new List<string>();
            foreach (var item in items)
                tmpList.Add(item.name);

            return tmpList;
        }

        public int GetID(string statusName)
        {
            foreach (var item in items)
            {
                if (item.name == statusName)
                    return item.id;
            }
            return -1;
        }

        public string GetName(int statusID)
        {
            foreach (var item in items)
            {
                if (item.id == statusID)
                    return item.name;
            }
            return string.Empty;
        }
    }

    [Serializable]
    public class OrderStatus
    {
        public int id;
        public string name;
    }
}
