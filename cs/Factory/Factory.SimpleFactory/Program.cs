using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory.SimpleFactory
{
    class Program
    {
        /// <summary>
        /// Simple factory pattern
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string treeName = args[0];

            TreeFactory factory = new TreeFactory();

            ITree tree = factory.CreateInstance(treeName);

            tree.Grows();
            tree.Dies();
        }
    }
}
