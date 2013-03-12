using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory.AbstractFactoryPattern
{
    public interface ITree
    {
        string Name { get; }
        void Grows();
        void Dies();
        void SetName(string name);
    }
}
