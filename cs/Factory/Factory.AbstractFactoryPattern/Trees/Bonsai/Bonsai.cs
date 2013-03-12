using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory.AbstractFactoryPattern
{
    public class Bonsai : ITree
    {
        private string size = string.Empty;
        public void SetName(string n)
        {
            if (n == null) throw new ArgumentNullException("name");
            Name = size + " " + n;
        }

        public string Name { get; private set; }

        void ITree.Grows()
        {
            Console.WriteLine("{0} Bonsais grow less than 80 cm in most cases.",size);
        }

        void ITree.Dies()
        {
            Console.WriteLine("{0} Bonsais can live over 80 years.",size);
        }        

        internal void SetSmallSize()
        {
            size = "Small";
        }

        internal void SetBigSize()
        {
            size = "Big";
        }
    }
}
