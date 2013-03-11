using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory.FactoryMethod.Trees
{
    class Cypress: ITree
    {
        public Cypress(string n)
        {
            Name = n;
        }
        public string Name { get; private set; }

        void ITree.Grows()
        {
            Console.WriteLine("Cypress can grow up to 30 m.");
        }

        void ITree.Dies()
        {
            Console.WriteLine("Cypress can live more than 2000 years.");
        }

        void ITree.SetName(string name)
        {
            if (name == null) throw new ArgumentNullException("name");
            Name = name;
            
        }
    }
}
