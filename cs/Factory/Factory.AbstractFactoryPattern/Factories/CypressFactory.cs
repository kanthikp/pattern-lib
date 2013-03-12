using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory.AbstractFactoryPattern
{
    public class CypressFactory : ITreeFactory
    {
        ITree ITreeFactory.CreateSmallTree()
        {
            return new CypressSmall();
        }

        ITree ITreeFactory.CreateBigTree()
        {
            return new CypressBig();
        }

        ITree ITreeFactory.CreateOldTree()
        {
            return new CypressOld();
        }
    }
}
