using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory.SimpleFactory
{
    class Bonsai: ITree
    {
        public void Grows()
        {
            Console.WriteLine("Bonsais grow less than 80 cm in most cases.");
        }

        public void Dies()
        {
            Console.WriteLine("Bonsais can live over 80 years.");
        }
    }
}
