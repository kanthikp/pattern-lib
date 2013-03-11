using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory.FactoryMethod.Trees
{
    class Bonsai : ITree
    {
        public void SetName(string n)
        {
            if (n == null) throw new ArgumentNullException("name");
            Name = n;
        }

        public string Name { get; private set; }

        void ITree.Grows()
        {
            Console.WriteLine("Bonsais grow less than 80 cm in most cases.");
        }

        void ITree.Dies()
        {
            Console.WriteLine("Bonsais can live over 80 years.");
        }

        void ITree.SetName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
