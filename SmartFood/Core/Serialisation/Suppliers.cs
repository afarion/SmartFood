using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core.Serialisation
{
    [Serializable]
    public class Suppliers
    {
        public List<Supplier> items;

        public List<string> ToList()
        {
            List<string> tmpList = new List<string>();
            foreach (var item in items)
                tmpList.Add(item.name);

            return tmpList;
        }

        public int GetID(string typeName)
        {
            foreach (var item in items)
            {
                if (item.name == typeName)
                    return item.id;
            }
            return -1;
        }

        public string GetName(int typeID)
        {
            foreach (var item in items)
            {
                if (item.id == typeID)
                    return item.name;
            }
            return string.Empty;
        }
    }

    [Serializable]
    public class Supplier
    {
        public int id;
        public string name;
        public string phone;
        public string email;
        public string skype;
        public string notes;
        public int visible;
    }
}
