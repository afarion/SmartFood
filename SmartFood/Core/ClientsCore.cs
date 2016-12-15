using SmartFood.Core.Constants;
using SmartFood.Core.Serialisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core
{
    public class ClientsCore : CoreBase
    {
        private static Clients clients = null;
        public static Clients Clients
        {
            get
            {
                if (clients == null)
                    GetClients();
                return clients;
            }
        }

        public static bool GetClients()
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.GET);
            bool isOk = SendGetRequest<Clients>(UriPostfix.CLIENTS, param, out clients);
            foreach(Client client in clients.items)
                client.addresses = ClientAddressesCore.GetClientsAddresses(client.id);

            return isOk;
        }

        public static bool AddClient(string name, string phone, string email, string comment="", int discount_fixed=0, string discount_reason="")
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.ADD);
            param.Add(RequestFields.NAME, name);
            param.Add(RequestFields.PHONE, phone);
            param.Add(RequestFields.EMEIL, email);
            param.Add(RequestFields.DISCOUNT_FIXED, discount_fixed.ToString());
            param.Add(RequestFields.COMMENT, comment);
            param.Add(RequestFields.DISCOUNT_REASONE, discount_reason);
            return SendEditRequest(UriPostfix.CLIENTS, param);
        }

        public static bool EditClient(int id,string name, string phone, string email, int discount_fixed, string comment, string discount_reason, int visible)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.EDIT);
            param.Add(RequestFields.ID, id.ToString());
            param.Add(RequestFields.NAME, name);
            param.Add(RequestFields.PHONE, phone);
            param.Add(RequestFields.EMEIL, email);
            param.Add(RequestFields.DISCOUNT_FIXED, discount_fixed.ToString());
            param.Add(RequestFields.COMMENT, comment);
            param.Add(RequestFields.DISCOUNT_REASONE, discount_reason);
            param.Add(RequestFields.VISIBLE, visible.ToString());
            return SendEditRequest(UriPostfix.CLIENTS, param);
        }
    }
}
