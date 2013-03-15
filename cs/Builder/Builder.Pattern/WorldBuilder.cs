using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Pattern
{
    // abstract builder
    public abstract class WorldBuilder
    {
        protected World world;

        public World GetWorld()
        {
            return world;
        }
        public void CreateNewWorld()
        {
            world = new World();
        }
        public abstract void AddSpecied();
        public abstract void ApplyNature();
        public abstract void PrepareEarth();
    }
}
