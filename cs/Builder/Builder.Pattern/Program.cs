using System;
using Builder.Pattern;
using System.Collections.Generic;

namespace Builder.Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new BraveNewWorldBuilder();
            builder.CreateWorld();
            var w = builder.GetWorld();

            w.Display();
            Console.ReadKey();
        }
    }
}
