using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Pattern
{
    // concrete builder
    class BraveNewWorldBuilder : WorldBuilder
    {
        public BraveNewWorldBuilder() {
            CreateNewWorld();
        }
        public override void AddSpecied()
        {
            world.species = new List<string> { "Bees", "Boas" };
        }

        public override void ApplyNature()
        {           
            world.grassType = World.GrassType.Bluegrass;
            world.hasTrees = true;
        }

        public override void PrepareEarth()
        {
            world.planetType = World.PlanetType.Terrestrial;
            world.canLive = true;
            world.mountainType = World.MountainType.Sedimentary;
            world.hasRocks = true;
        }
    }
}
