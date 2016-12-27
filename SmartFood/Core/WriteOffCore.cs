using SmartFood.Core.Constants;
using SmartFood.Core.Serialisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core
{
    public class WriteOffCore: CoreBase
    {
        private static WriteOffs writeOffs = null;
        public static WriteOffs WriteOffs
        {
            get
            {
                if (writeOffs == null)
                    GetWriteOff();
                return writeOffs;
            }
        }

        public static bool GetWriteOff()
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.GET);
            return SendGetRequest<WriteOffs>(UriPostfix.WRITEOFF, param, out writeOffs);
        }

        public static int AddWriteOff(int consumble_id, int employee_id, double amont, string comment)
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.ADD);
            param.Add(RequestFields.CONSUMBLE_ID, consumble_id.ToString());
            param.Add(RequestFields.ID_EMPLOYEE, employee_id.ToString());
            param.Add(RequestFields.AMOUNT, amont.ToString());
            param.Add(RequestFields.COMMENT, comment);
            return SendEditRequestID(UriPostfix.WRITEOFF, param);
        }
    }
}
