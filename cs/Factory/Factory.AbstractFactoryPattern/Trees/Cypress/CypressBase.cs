using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory.AbstractFactoryPattern
{
    public class CypressBase : ITree
    {
        public CypressBase(string n)
        {
            Name = n;
        }
        public string Name { get; private set; }

        void ITree.Grows()
        {
            Console.WriteLine("{0} Cypress can grow up to 30 m.",Name);
        }

        void ITree.Dies()
        {
            Console.WriteLine("{0} Cypress can live more than 2000 years.",Name);
        }

        void ITree.SetName(string name)
        {
            if (name == null) throw new ArgumentNullException("name");
            Name = name;
            
        }
    }
}
