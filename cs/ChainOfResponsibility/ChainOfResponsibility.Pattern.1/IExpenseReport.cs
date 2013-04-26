using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility.Pattern._1
{
    public interface IExpenseReport
    {
        Decimal Total { get; }
    }
}
