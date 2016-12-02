using SmartFood.Core.Serialisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core
{
    public class MeasuresCore : CoreBase
    {
        public static Measures measures = null;

        public static bool GetMeasures()
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("action", "view");
            return SendGetRequest<Measures>(UriPostfix.MEASURES, param, out measures);
        }
    }
}
