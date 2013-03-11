using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Factory.FactoryMethod.Factories;
using Factory.FactoryMethod.Trees;

namespace Factory.FactoryMethod.Factories
{
    class BonsaiFactory : ITreeFactory
    {
        public ITree CreateTree()
        {
            var bonsai = new Bonsai();
            bonsai.SetName("Bonsai Adenium Obesum");
            return bonsai;
        }
    }
}
