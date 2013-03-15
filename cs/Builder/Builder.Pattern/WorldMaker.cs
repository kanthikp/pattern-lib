using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Pattern
{
    // director
    class WorldMaker
    {
        private readonly WorldBuilder builder;
        public WorldMaker(WorldBuilder builder)
        {
            this.builder = builder;
        }
        public void BuildWorld()
        {
            builder.PrepareEarth();
            builder.ApplyNature();
            builder.AddSpecied();
        }
        public World GetWorld()
        {
            return builder.GetWorld();
        }
    }
}
