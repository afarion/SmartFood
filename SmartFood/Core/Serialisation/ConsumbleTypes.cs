﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core.Serialisation
{
    [Serializable]
    public class ConsumbleTypes
    {
        public int count;
        public List<ConsumbleType> items;

        public List<string> ToList()
        {
            List<string> tmpList = new List<string>();
            foreach (var item in items)
            {
                if(item.visible != 0)
                    tmpList.Add(item.name);
            }
            return tmpList;
        }

        public int GetID(string typeName)
        {
            foreach (var item in items)
            {
                if (item.name == typeName)
                    return item.id;
            }
            return -1;
        }

        public string GetName(long typeID)
        {
            foreach (var item in items)
            {
                if (item.id == typeID)
                    return item.name;
            }
            return string.Empty;
        }
    }

    [Serializable]
    public class ConsumbleType
    {
        public int id;
        public string name;
        public int visible;
    }
}
