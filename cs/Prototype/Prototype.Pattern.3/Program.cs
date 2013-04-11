using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype.Pattern._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var complicatedObject = ComplicatedUnstableObject.Reference(); ; //new ComplicatedUnstableObject can't do new here from the outside
            var complicatedObject2 = complicatedObject.Clone();
        }
    }
}
