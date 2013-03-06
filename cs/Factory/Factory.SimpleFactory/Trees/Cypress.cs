using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory.SimpleFactory
{
    class Cypress:ITree
    {
        public void Grows()
        {
            Console.WriteLine("Cypress can grow up to 30 m.");
        }

        public void Dies()
        {
            Console.WriteLine("Cypress can live more than 2000 years.");
        }
    }
}
