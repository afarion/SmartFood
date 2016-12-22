using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core.Serialisation
{
    [Serializable]
    public class Consumbles
    {
        public List<Consumble> items;
        public List<string> ToList()
        {
            List<string> tmpList = new List<string>();
            foreach (var item in items)
                tmpList.Add(item.name);

            return tmpList;
        }

        public int GetID(string consumbleName)
        {
            foreach (var item in items)
            {
                if (item.name == consumbleName)
                    return item.id;
            }
            return -1;
        }

        public string GetName(long typeID)
        {
            foreach (var item in items)
            {
                if (item.id == typeID)
                    return item.name;
            }
            return string.Empty;
        }

        public string GetMeasure(long id)
        {
            foreach (var item in items)
            {
                if (item.id == id)
                    return MeasuresCore.Measures.GetName(item.id_unit);
            }
            return string.Empty;
        }

        public Consumble GetConsumble(string consumbleName)
        {
            foreach (var item in items)
            {
                if (item.name == consumbleName)
                    return item;
            }
            return null;
        }
    }

    [Serializable]
    public class Consumble
    {
        public int id;
        public string name;
        public int id_type;
        public int id_category;
        public int id_unit;
        public double amount;
        public double price;
        public int visible;
        public int waste_pct;
    }
}
