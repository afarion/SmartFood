using SmartFood.Core.Constants;
using SmartFood.Core.Serialisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core
{
    public class EmployeesCore : CoreBase
    {
        private static Employees emplyees = null;
        public static Employees Emplyees
        {
            get
            {
                if (emplyees == null)
                    GetEmplyees();
                return emplyees;
            }
        }

        public static bool GetEmplyees()
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.GET);
            return SendGetRequest<Employees>(UriPostfix.EMPLOYEES, param, out emplyees);
        }

        public static bool AddEmplyee(string first_name, string last_name, string id_type, string phone, string phone_ex, string emeil, string adress, string skype,string birthday, string comment)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.ADD);
            param.Add(RequestFields.FIRST_NAME, first_name);
            param.Add(RequestFields.LAST_NAME, last_name);
            param.Add(RequestFields.ID_TYPE, id_type);
            param.Add(RequestFields.PHONE, phone);
            param.Add(RequestFields.PHONE_EX, phone_ex);
            param.Add(RequestFields.EMEIL, emeil);
            param.Add(RequestFields.ADRESS, adress);
            param.Add(RequestFields.SKYPE, skype);
            param.Add(RequestFields.BIRTHDAY, birthday);
            param.Add(RequestFields.COMMENT, comment);
            return SendEditRequest(UriPostfix.EMPLOYEES, param);
        }

        public static bool EditEmplyee(string id, string first_name, string last_name, string id_type, string phone, string phone_ex, string emeil, string adress, string skype, string birthday, string comment, string visible)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.EDIT);
            param.Add(RequestFields.ID, id);
            param.Add(RequestFields.FIRST_NAME, first_name);
            param.Add(RequestFields.LAST_NAME, last_name);
            param.Add(RequestFields.ID_TYPE, id_type);
            param.Add(RequestFields.PHONE, phone);
            param.Add(RequestFields.PHONE_EX, phone_ex);
            param.Add(RequestFields.EMEIL, emeil);
            param.Add(RequestFields.ADRESS, adress);
            param.Add(RequestFields.SKYPE, skype);
            param.Add(RequestFields.BIRTHDAY, birthday);
            param.Add(RequestFields.COMMENT, comment);
            param.Add(RequestFields.VISIBLE, visible);
            return SendEditRequest(UriPostfix.EMPLOYEES, param);
        }
    }
}
