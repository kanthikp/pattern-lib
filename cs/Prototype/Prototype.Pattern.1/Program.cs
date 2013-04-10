using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype.Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var digger = new WebPageDigger("http://www.google.com");
            digger.PrintPageData();

            var digger2 = digger.Clone() as WebPageDigger;
            digger2.headerTagCount = -9;
            digger2.PrintPageData();
            Console.WriteLine("--------");
            digger.PrintPageData();

            Console.ReadKey();
        }
    }
}
