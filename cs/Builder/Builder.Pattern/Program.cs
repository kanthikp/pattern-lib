using System;
using Builder.Pattern;
using System.Collections.Generic;

namespace Builder.Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            World w = new World();
            w.planetType = World.PlanetType.Terrestrial;
            w.canLive = true;
            w.mountainType =World.MountainType.Sedimentary;
            w.grassType = World.GrassType.Bluegrass;
            w.hasRocks = true;
            w.hasTrees = true;
            w.species = new List<string> { "Bees","Boas" };

            w.Display();
            Console.ReadKey();
        }
    }
}
