using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility.Pattern._1
{
    public class ExpenseReport: IExpenseReport
    {
        public ExpenseReport(Decimal t)
        {
            Total = t;
        }

        public decimal Total
        {
            get;
            private set;
        }
    }
}
