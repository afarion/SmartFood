using SmartFood.Core.Constants;
using SmartFood.Core.Serialisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core
{
    public class EmployeesTypesCore : CoreBase
    {
        private static EmployesTypes employeesTypes = null;
        public static EmployesTypes EmployeesTypes
        {
            get
            {
                if (employeesTypes == null)
                    GetEmployeesTypes();
                return employeesTypes;
            }
        }

        public static bool GetEmployeesTypes()
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.GET);
            return SendGetRequest<EmployesTypes>(UriPostfix.EMPLOYEES_TYPES, param, out employeesTypes);
        }
    }
}
