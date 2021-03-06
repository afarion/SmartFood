﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core.Serialisation
{
    [Serializable]
    public class GoodsCategories
    {
        public List<GoodsCategorie> items;
        public int count;

        public List<string> ToList()
        {
            List<string> tmpList = new List<string>();
            foreach (var item in items)
                tmpList.Add(item.name);

            return tmpList;
        }

        public int GetID(string categorieName)
        {
            foreach (var item in items)
            {
                if (item.name == categorieName)
                    return item.id;
            }
            return -1;
        }

        public string GetName(int categorieID)
        {
            foreach (var item in items)
            {
                if (item.id == categorieID)
                    return item.name;
            }
            return string.Empty;
        }
    }

    [Serializable]
    public class GoodsCategorie
    {
       public int id;
       public string name;
    }
}
