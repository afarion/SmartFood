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
    }

    [Serializable]
    public class Good
    {
        public int id;
        public int id_category;
        public string name;
        public double weight;
        public double price;
        public string category;
        public int visible;
        [NonSerialized]
        public GoodConsumbles consumbles;
    }
}
