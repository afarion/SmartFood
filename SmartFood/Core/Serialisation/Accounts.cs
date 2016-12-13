using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core.Serialisation
{
    [Serializable]
    public class Accounts
    {
        public List<Account> items;

        public List<string> ToList()
        {
            List<string> tmpList = new List<string>();
            foreach (var item in items)
            {
                if (item.visible != 0)
                    tmpList.Add(item.login);
            }
            return tmpList;
        }

        public int GetID(string login)
        {
            foreach (var item in items)
            {
                if (item.login == login)
                    return item.id;
            }
            return -1;
        }

        public string GetLogin(int id)
        {
            foreach (var item in items)
            {
                if (item.id == id)
                    return item.login;
            }
            return string.Empty;
        }
    }

    [Serializable]
    public class Account
    {
        public int id;
        public EAcountType id_type;
        public int id_employee;
        public string login;
        public int visible;
    }
}
