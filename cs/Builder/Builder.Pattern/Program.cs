using System;
using Builder.Pattern;
using System.Collections.Generic;

namespace Builder.Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // brave new world
            var wMaker = new WorldMaker(new BraveNewWorldBuilder());
            wMaker.BuildWorld();
            var w = wMaker.GetWorld();
            w.Display();
            // space jam world
            var wMaker2 = new WorldMaker(new SpaceJamWorldBuilder());
            wMaker2.BuildWorld();
            var w2 = wMaker2.GetWorld();
            w2.Display();

            Console.ReadKey();
        }
    }
}
