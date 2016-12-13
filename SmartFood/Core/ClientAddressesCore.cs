using SmartFood.Core.Constants;
using SmartFood.Core.Serialisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core
{
    public class ClientAddressesCore:CoreBase
    {
        public static ClientAddresses GetClientsAddresses(int clientId)
        {
            ClientAddresses clientAddresses = null;
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.GET);
            param.Add(RequestFields.CLIENT, clientId.ToString());
            SendGetRequest<ClientAddresses>(UriPostfix.CLIENTS_ADDRESSES, param, out clientAddresses);
            return clientAddresses;
        }

        public static bool AddClientAddress(int clientId,string address)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.ADD);
            param.Add(RequestFields.CLIENT_ID, clientId.ToString());
            param.Add(RequestFields.ADDRESS, address);
            return SendEditRequest(UriPostfix.CLIENTS_ADDRESSES, param);
        }

        public static bool RemoveClientAddress(int id)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.REMOVE);
            param.Add(RequestFields.ID, id.ToString());
            return SendEditRequest(UriPostfix.CLIENTS_ADDRESSES, param);
        }
    }
}
