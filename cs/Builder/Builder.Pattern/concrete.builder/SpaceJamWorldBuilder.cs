using System;
using System.Collections.Generic;

namespace Builder.Pattern
{
    // concrete builder
    class SpaceJamWorldBuilder : WorldBuilder
    {
        public SpaceJamWorldBuilder()
        {
            CreateNewWorld();
        }
        public override void AddSpecied()
        {
            world.species = new List<string> { "Sharks", "Dogs" };
        }

        public override void ApplyNature()
        {
            world.grassType = World.GrassType.Fescues;
            world.hasTrees = true;
        }

        public override void PrepareEarth()
        {
            world.planetType = World.PlanetType.SuperEarths;
            world.canLive = true;
            world.mountainType = World.MountainType.Glacial;
            world.hasRocks = true;
        }
    }
}
