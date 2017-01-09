using SmartFood.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core.Serialisation
{
    [Serializable]
    public class Employees
    {
        public List<Employee> items;

        public List<string> ToList()
        {
            List<string> tmpList = new List<string>();
            foreach (var item in items)
                tmpList.Add(string.Format("{0} {1}", item.last_name, item.first_name));

            return tmpList;
        }

        public List<string> GetCouriers()
        {
            List<string> tmpList = new List<string>();
            foreach (var item in items)
            {
                if (item.id_type == 6)
                    tmpList.Add(string.Format("{0} {1}", item.last_name, item.first_name));
            }
            return tmpList;
        }

        public int GetID(string fullName)
        {
            foreach (var item in items)
            {
                if (string.Format("{0} {1}", item.last_name, item.first_name) == fullName)
                    return item.id;
            }
            return -1;
        }

        public string GetEmployeeFullName(int employeeID)
        {
            foreach (var item in items)
            {
                if (item.id == employeeID)
                    return string.Format("{0} {1}", item.last_name, item.first_name);
            }
            return string.Empty;
        }

        public string GetEmployeePosition(int employeeID)
        {
            foreach (var item in items)
            {
                if (item.id == employeeID)
                    return EmployeesTypesCore.EmployeesTypes.GetName(item.id);
            }
            return string.Empty;
        }

        public Employee GetEmployee(int id)
        {
            foreach (var item in items)
            {
                if (item.id == id)
                    return item;
            }
            return null;
        }
    }

    [Serializable]
    public class Employee
    {
        public int id;
        public int id_type;
        public string first_name;
        public string last_name;
        public string phone;
        public string phone_ex;
        public string skype;
        public string address;
        public string email;
        public string birthday;
        public string comment;
        public int visible;
    }
}
