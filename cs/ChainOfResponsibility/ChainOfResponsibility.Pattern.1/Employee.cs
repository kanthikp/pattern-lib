using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility.Pattern._1
{
    public class Employee : IExpenseApprover
    {
        private readonly Decimal _approvalLimit;
        public string Name { get; private set; }


        public Employee(string name, Decimal approvalLimit)
        {
            Name = name;
            _approvalLimit = approvalLimit;
        }

        public ApprovalResponse ApproveExpense(IExpenseReport expenseReport)
        {
            return expenseReport.Total > _approvalLimit ? ApprovalResponse.BeyondApprovalLimit : ApprovalResponse.Approved;
        }
    }
}
