using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge.Pattern._1
{
    public interface IFormatter
    {
        string Format(string key, string value);        
    }
}
