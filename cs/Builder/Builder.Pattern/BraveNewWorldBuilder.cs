using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Pattern
{
    class BraveNewWorldBuilder
    {
        World world;
        public World GetWorld()
        {           
            return world;
        }
        public void CreateWorld()
        {
            world = new World();
            PrepareEarth();
            ApplyNature();
            AddSpecied();          
        }

        private void AddSpecied()
        {
            world.species = new List<string> { "Bees", "Boas" };
        }

        private void ApplyNature()
        {           
            world.grassType = World.GrassType.Bluegrass;
            world.hasTrees = true;
        }

        private void PrepareEarth()
        {
            world.planetType = World.PlanetType.Terrestrial;
            world.canLive = true;
            world.mountainType = World.MountainType.Sedimentary;
            world.hasRocks = true;
        }
    }
}
