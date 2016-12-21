using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core.Serialisation
{
    [Serializable]
    public class GoodConsumbles
    {
        public int count;
        public List<GoodConsumble> items;
    }
    [Serializable]
    public class GoodConsumble
    {
        public int id;
        public int id_dish;
        public int id_item;
        public double weight;
        public string item;
        public int visible;
    }
}
