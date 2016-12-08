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
                return Emplyees;
            }
        }

        public static bool GetEmplyees()
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.GET);
            return SendGetRequest<Employees>(UriPostfix.EMPLOYEES, param, out emplyees);
        }

        //public static bool AddEmplyee(string name, string phone = "", string emeil = "", string skype = "", string notes = "")
        //{
        //    Dictionary<string, string> param = new Dictionary<string, string>();
        //    param.Add(RequestFields.ACTION, Actions.ADD);
        //    param.Add(RequestFields.NAME, name);
        //    param.Add(RequestFields.PHONE, phone);
        //    param.Add(RequestFields.EMEIL, emeil);
        //    param.Add(RequestFields.SKYPE, skype);
        //    param.Add(RequestFields.NOTES, notes);
        //    return SendEditRequest(UriPostfix.SUPPLIERS, param);
        //}

        //public static bool EditEmplyee(string id, string name, string phone, string emeil, string skype, string notes, string visible)
        //{
        //    Dictionary<string, string> param = new Dictionary<string, string>();
        //    param.Add(RequestFields.ACTION, Actions.EDIT);
        //    param.Add(RequestFields.ID, id);
        //    param.Add(RequestFields.NAME, name);
        //    param.Add(RequestFields.PHONE, phone);
        //    param.Add(RequestFields.EMEIL, emeil);
        //    param.Add(RequestFields.SKYPE, skype);
        //    param.Add(RequestFields.NOTES, notes);
        //    param.Add(RequestFields.VISIBLE, visible);
        //    return SendEditRequest(UriPostfix.SUPPLIERS, param);
        //}
    }
}
