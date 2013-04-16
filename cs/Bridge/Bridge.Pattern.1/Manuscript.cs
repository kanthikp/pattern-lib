using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge.Pattern._1
{
    public abstract class Manuscript
    {
        protected readonly IFormatter formatter;

        public Manuscript(IFormatter formatter)
        {
            this.formatter = formatter;
        }
        abstract public void Print();
    }
}
