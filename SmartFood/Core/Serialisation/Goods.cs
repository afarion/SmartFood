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

        public int GetId(string name)
        {
            foreach(Good good in items)
            {
                if (good.name == name)
                    return good.id;
            }

            return -1;
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
