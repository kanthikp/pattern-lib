using System.Collections.Generic;
using System;
namespace Builder.Pattern
{
    // product
    public class World
    {
        public  PlanetType planetType {get;  set;}
        public  bool canLive { get;  set; }
        public  MountainType mountainType { get;  set; }
        public  GrassType grassType { get;  set; }
        public  bool hasTrees { get;  set; }
        public  bool hasRocks { get;  set; }
        public  List<string> species { get;  set; }        

        public void Display()
        {
            Console.WriteLine("World has {0} type", planetType);
            if(canLive)
                Console.WriteLine("Can live");
            if(hasRocks)
                Console.WriteLine("Has rocks");
            if (hasTrees)
                Console.WriteLine("Has trees");
            Console.WriteLine("Species");
            foreach (var s in species)
                Console.WriteLine(" {0}", s);
        }    
        public enum PlanetType { Terrestrial, SuperEarths, Pulsar, Circumbinary }
        public enum MountainType { Volcanoes, Glacial, Sedimentary, Metamorphic, Dome }
        public enum GrassType { Bluegrass, Bentgrass, Ryegrasses, Fescues, RedFescues, FeatherReedGrass }    
    }    
}
