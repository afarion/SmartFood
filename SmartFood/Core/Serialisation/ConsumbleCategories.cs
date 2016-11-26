using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core.Serialisation
{
    [Serializable]
    public class ConsumbleCategories
    {
        public List<ConsumbleCategorie> categories;
    }

    [Serializable]
    public class ConsumbleCategorie
    {
        public long ID;
        public string name;
        public int visible;
    }
}
