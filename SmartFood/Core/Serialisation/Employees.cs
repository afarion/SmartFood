using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core.Serialisation
{
    [Serializable]
    public class Employees
    {
        public List<Emplyee> items;

        public List<string> ToList()
        {
            List<string> tmpList = new List<string>();
            foreach (var item in items)
                tmpList.Add(item.last_name);

            return tmpList;
        }

        public int GetID(string soureName)
        {
            foreach (var item in items)
            {
                if (item.last_name == soureName)
                    return item.id;
            }
            return -1;
        }

        public string GetSoureName(int typeID)
        {
            foreach (var item in items)
            {
                if (item.id == typeID)
                    return item.last_name;
            }
            return string.Empty;
        }
    }

    [Serializable]
    public class Emplyee
    {
        public int id;
        public int id_type;
        public string first_name;
        public string last_name;
        public string phone;
        public string phone_ex;
        public string skype;
        public string address;
        public string email;
        public string birthday;
        public string comment;
        public int visible;
    }
}
