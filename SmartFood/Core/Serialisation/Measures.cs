using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core.Serialisation
{
    [Serializable]
    public class Measures
    {
        public List<Measure> items;
    }

    [Serializable]
    public class Measure
    {
        public int id;
        public string name;
        public string abbr;
    }
}
