using SmartFood.Core.Constants;
using SmartFood.Core.Serialisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core
{
    public class SuppliersCore : CoreBase
    {
        private static Suppliers suppliers = null;
        public static Suppliers Suppliers
        {
            get
            {
                if (suppliers == null)
                    GetSuppliers();
                return suppliers;
            }
        }

        public static bool GetSuppliers()
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.GET);
            return SendGetRequest<Suppliers>(UriPostfix.SUPPLIERS, param, out suppliers);
        }

        public static int AddSuplier(string name, string phone = "", string emeil = "", string skype = "", string notes = "")
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.ADD);
            param.Add(RequestFields.NAME, name);
            param.Add(RequestFields.PHONE, phone);
            param.Add(RequestFields.EMEIL, emeil);
            param.Add(RequestFields.SKYPE, skype);
            param.Add(RequestFields.NOTES, notes);
            return SendEditRequestID(UriPostfix.SUPPLIERS, param);
        }

        public static bool EditSuplier(string id, string name, string phone, string emeil, string skype, string notes, string visible)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.EDIT);
            param.Add(RequestFields.ID, id);
            param.Add(RequestFields.NAME, name);
            param.Add(RequestFields.PHONE, phone);
            param.Add(RequestFields.EMEIL, emeil);
            param.Add(RequestFields.SKYPE, skype);
            param.Add(RequestFields.NOTES, notes);
            param.Add(RequestFields.VISIBLE, visible);
            return SendEditRequest(UriPostfix.SUPPLIERS, param);
        }
    }
}
