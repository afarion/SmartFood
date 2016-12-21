using SmartFood.Core.Constants;
using SmartFood.Core.Serialisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core
{
    public class ArrivalCore : CoreBase
    {
        private static Arrivals arrivals = null;
        public static Arrivals Arrivals
        {
            get
            {
                if (arrivals == null)
                    GetArrivals();
                return arrivals;
            }
        }

        public static bool GetArrivals()
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.GET);
            return SendGetRequest<Arrivals>(UriPostfix.ARRIVALS, param, out arrivals);
        }


        public static bool AddArrival(int consumble_id, int supplier_id, int employee_id, double amont, double price)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.ADD);
            param.Add(RequestFields.CONSUMBLE_ID, consumble_id.ToString());
            param.Add(RequestFields.SUPPLIER_ID, supplier_id.ToString());
            param.Add(RequestFields.ID_EMPLOYEE, employee_id.ToString());
            param.Add(RequestFields.AMOUNT, amont.ToString());
            param.Add(RequestFields.PRICE, price.ToString());
            return SendEditRequest(UriPostfix.ARRIVALS, param);
        }
    }
}
