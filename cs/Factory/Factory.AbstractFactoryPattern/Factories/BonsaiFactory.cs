using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory.AbstractFactoryPattern
{
    public class BonsaiFactory : ITreeFactory
    {
        ITree ITreeFactory.CreateSmallTree()
        {
            var b = new Bonsai();
            b.SetSmallSize();
            return b;
        }

        ITree ITreeFactory.CreateBigTree()
        {
            var b = new Bonsai();
            b.SetBigSize();
            return b;
        }

        ITree ITreeFactory.CreateOldTree()
        {
            return new Bonsai();
        }
    }
}
