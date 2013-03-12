using System;
using Builder.Pattern;
using System.Collections.Generic;
namespace Builder.Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
           World w =  new World(World.PlanetType.Terrestrial,true, World.MountainType.Sedimentary,World.GrassType.Bluegrass,
                        true,true,new List<string>{"Bees"});
           w.Display();
           Console.ReadKey();
        }
    }
}
