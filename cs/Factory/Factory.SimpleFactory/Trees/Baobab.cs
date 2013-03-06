using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory.SimpleFactory
{
    class Baobab: ITree
    {
        public void Grows()
        {
            Console.WriteLine("Baobab grows 30 m tall.");
        }

        public void Dies()
        {
            Console.WriteLine("Baobab lives more than 6000 years they say.");
        }
    }
}
