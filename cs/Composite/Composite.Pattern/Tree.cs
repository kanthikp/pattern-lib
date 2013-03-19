using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite.Pattern
{
    public class Tree
    {
        public string Name { get; set; }
        public int Leafs { get; set; }

        public void Stats() {
            Console.WriteLine("{0} has {1} leafs.", Name, Leafs);
        }
    }
}
