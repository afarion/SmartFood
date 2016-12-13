using SmartFood.Core.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core
{
    public enum EAcountType { Admin = 1, Operator = 2, Cook = 3 };

    public class AcountTypesCore
    {
        private static Dictionary<EAcountType, string> types;
        public static Dictionary<EAcountType, string> Types
        {
            get
            {
                if (types == null)
                {
                    types = new Dictionary<EAcountType, string>();
                    types.Add(EAcountType.Admin, GeneralConstants.ADMINISTRATOR);
                    types.Add(EAcountType.Operator, GeneralConstants.OPERATOR);
                    types.Add(EAcountType.Cook, GeneralConstants.COOK);
                }
                return types;
            }
        }

        public static List<string> ToList()
        {
            List<string> tmpList = new List<string>();
            foreach (var item in Types)
                tmpList.Add(item.Value);
            return tmpList;
        }

        public static string GetAcountType(EAcountType typeKey)
        {
            return types[typeKey];
        }

        public static int GetAcountType(string type)
        {
            foreach (var item in Types)
            {
                if (item.Value == type)
                    return Convert.ToInt32(item.Key);
            }
            return -1;
        }
    }
}