using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core
{

    public class ComboBoxItem
    {
        public long ID { get; }
        public string Name { get; }

        public ComboBoxItem(long id,string name)
        {
            ID = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
