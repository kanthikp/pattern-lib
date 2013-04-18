using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy.Pattern._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //test 1
            Console.WriteLine("test 1: Order Should Populate Itself Fully On Creation\n");
            var o1 = new Order(1);
            ConsoleReporting.PrintOrderDetails(o1);
            //test 2
            Console.WriteLine("test 2: Order Should Defer Object Creation Until Access\n");
            var o2 = new OrderProxy(2);
            ConsoleReporting.PrintOrderDetails(o2);
            Console.WriteLine("Again: " + o2.Customer.Name);
            foreach (var i in o1.Items)
            {
                Console.WriteLine("items: " + i.Name);
            }
            //test 3
            Console.WriteLine("test 3: Lazy Order Should Defer Object Creation Until Access\n");
            var o3 = new LazyOrder(1);
            ConsoleReporting.PrintOrderDetails(o3);
            
            Console.ReadKey();
        }
    }
}
