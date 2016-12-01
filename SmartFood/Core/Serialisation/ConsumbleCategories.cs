using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core.Serialisation
{
    [Serializable]
    public class ConsumbleCategories
    {
        public List<ConsumbleCategorie> items;
    }

    [Serializable]
    public class ConsumbleCategorie
    {
        public long id;
        public string name;
        public int id_type;
        public int visible;
    }
}
