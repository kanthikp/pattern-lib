using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite.Pattern
{
    public interface Forest
    {
        int Leafs { get; set; }
        void Stats();
    }
}
