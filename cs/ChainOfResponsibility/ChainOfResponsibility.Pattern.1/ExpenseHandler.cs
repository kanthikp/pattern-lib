using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility.Pattern._1
{
    public interface IExpenseHandler
    {
        ApprovalResponse Approve(IExpenseReport expenseReport);
        void RegisterNext(IExpenseHandler next);
    }

    public class ExpenseHandler : IExpenseHandler
    {
        private readonly IExpenseApprover _approver;
        private IExpenseHandler _next;

        public ExpenseHandler(IExpenseApprover expenseApprover)
        {
            _approver = expenseApprover;
            _next = EndOfChainExpenseHandler.Instance;
        }

        public ApprovalResponse Approve(IExpenseReport expenseReport)
        {
            ApprovalResponse response = _approver.ApproveExpense(expenseReport);
            if (response == ApprovalResponse.BeyondApprovalLimit && _next != null)
            {
                return _next.Approve(expenseReport);
            }
            return response;
        }

        public void RegisterNext(IExpenseHandler next)
        {
            _next = next;
        }
    }
}
