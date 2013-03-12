using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory.AbstractFactoryPattern
{
    public interface ITreeFactory
    {
        ITree CreateSmallTree();
        ITree CreateBigTree();
        ITree CreateOldTree();
    }
}
