using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory.SimpleFactory
{
    class NullTree : ITree
    {
        public void Grows()
        {
            Console.WriteLine("Tree does not exist. It cannot grows.");
        }

        public void Dies()
        {
            Console.WriteLine("Tree does not exist. It cannot dies.");
        }
    }
}
