using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core.Serialisation
{
    [Serializable]
    public class Goods
    {
        public int count;
        public List<Good> items;

        public List<string> ToList()
        {
            List<string> tmpList = new List<string>();
            foreach (var item in items)
                tmpList.Add(item.name);

            return tmpList;
        }

        public int GetId(string name)
        {
            foreach(Good good in items)
            {
                if (good.name == name)
                    return good.id;
            }

            return -1;
        }

        public Good GetGood(string name)
        {
            foreach (Good good in items)
            {
                if (good.name == name)
                    return good;
            }

            return null;

        }
        public Good GetGood(int id)
        {
            foreach (Good good in items)
            {
                if (good.id == id)
                    return good;
            }

            return null;
        }

        public string GetName(int id)
        {
            foreach (Good good in items)
            {
                if (good.id == id)
                    return good.name;
            }

            return null;
        }
    }

    [Serializable]
    public class Good
    {
        public int id;
        public int id_category;
        public string name;
        public double weight;
        public double price;
        public int visible;
        [NonSerialized]
        public GoodConsumbles consumbles;
    }
}
