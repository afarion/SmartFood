using SmartFood.Core.Constants;
using SmartFood.Core.Serialisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core
{
    public class AcountsCore : CoreBase
    {
        private static Accounts acounts = null;
        public static Accounts Acounts
        {
            get
            {
                if (acounts == null)
                    GetAcounts();
                return acounts;
            }
        }

        public static bool GetAcounts()
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.GET);
            return SendGetRequest<Accounts>(UriPostfix.ACOUNTS, param, out acounts);
        }
        public static bool AddAcount(string login, int id_type, int id_employee, string pass)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.ADD);
            param.Add(RequestFields.LOGIN, login);
            param.Add(RequestFields.ID_TYPE, id_type.ToString());
            param.Add(RequestFields.ID_EMPLOYEE, id_employee.ToString());
            param.Add(RequestFields.PASSWORD, pass);
            return SendEditRequest(UriPostfix.ACOUNTS, param);
        }

        public static bool EditAcount(string id, string login, int id_type, int id_employee, string pass, string visible)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.EDIT);
            param.Add(RequestFields.ID, id);
            param.Add(RequestFields.LOGIN, login);
            param.Add(RequestFields.ID_TYPE, id_type.ToString());
            param.Add(RequestFields.ID_EMPLOYEE, id_employee.ToString());
            param.Add(RequestFields.PASSWORD, pass);
            param.Add(RequestFields.VISIBLE, visible);
            return SendEditRequest(UriPostfix.ACOUNTS, param);
        }
    }
}
