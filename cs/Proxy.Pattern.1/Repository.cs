using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy.Pattern._1
{
    public abstract class Repository<T>
    {
        public abstract T GetById(int id);
    }
}
