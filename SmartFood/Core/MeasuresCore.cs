using SmartFood.Core.Constants;
using SmartFood.Core.Serialisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core
{
    public class MeasuresCore : CoreBase
    {
        private static Measures measures = null;
        public static Measures Measures
        {
            get
            {
                if (measures == null)
                    GetMeasures();
                return measures;
            }
        }

        public static bool GetMeasures()
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add(RequestFields.ACTION, Actions.GET);
            return SendGetRequest<Measures>(UriPostfix.MEASURES, param, out measures);
        }
    }
}
