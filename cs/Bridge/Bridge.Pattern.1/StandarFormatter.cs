using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge.Pattern._1
{
    public class StandarFormatter: IFormatter
    {
        public string Format(string k, string v)
        {
            return string.Format("{0}: {1}", k, v);
        }
    }
}
