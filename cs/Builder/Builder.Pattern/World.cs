using System.Collections.Generic;
using System;
namespace Builder.Pattern
{
    public class World
    {
        private readonly PlanetType planetType;
        private readonly bool canLive;
        private readonly MountainType mountainType;
        private readonly GrassType grassType;
        private readonly bool hasTrees;
        private readonly bool hasRocks;
        private readonly List<string> species;

        public enum PlanetType{Terrestrial, SuperEarths, Pulsar, Circumbinary}
        public enum MountainType{Volcanoes, Glacial, Sedimentary, Metamorphic, Dome}
        public enum GrassType{Bluegrass, Bentgrass, Ryegrasses, Fescues, RedFescues, FeatherReedGrass}

        public World(PlanetType planetType,bool canLive,MountainType mountainType,GrassType grassType,bool hasTrees,  
                        bool hasRocks,List<string> species)
        {
            this.planetType =planetType;
            this.canLive = canLive;
            this.mountainType =mountainType;
            this.grassType =grassType; 
            this.hasTrees =hasTrees;
            this.hasRocks =hasRocks;
            this.species = species;
        }

        public void Display()
        {
            Console.WriteLine("World is off {0} type", planetType);
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
    }
}
