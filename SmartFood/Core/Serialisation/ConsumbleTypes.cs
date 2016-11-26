using System;
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
    }

    [Serializable]
    public class ConsumbleType
    {
        public long id;
        public string name;
        public int visible;
    }
}
