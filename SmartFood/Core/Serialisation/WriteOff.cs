﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core.Serialisation
{
    [Serializable]
    public class WriteOffs
    {
        public int count;
        public List<WriteOff> items;

        public WriteOff GetWriteOff(int id)
        {
            foreach (WriteOff writeOff in items)
            {
                if (writeOff.id == id)
                    return writeOff;
            }

            return null;
        }
    }
    [Serializable]
    public class WriteOff
    {
        public int id;
        public int id_item;
        public int id_admin;
        public int id_employee;
        public double amount;
        public double waste;
        public string comment;
        public DateTime date_create;
    }
}
