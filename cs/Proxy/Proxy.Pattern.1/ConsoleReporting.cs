using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy.Pattern._1
{
    static class ConsoleReporting
    {
        public static void PrintOrderDetails(Order o)
        {
            Console.WriteLine("Displaying Order Information");
            Console.WriteLine("Order Date: " + o.OrderDate.Date);
            Console.WriteLine("Customer: " + o.Customer.Name);
        }
    }
}
