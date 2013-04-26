using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility.Pattern._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> managers = new List<Employee>
                                    {
                                        new Employee("will worker", Decimal.Zero),
                                        new Employee("mary manager", new Decimal(1000)),
                                        new Employee("victor vpres", new Decimal(5000)),
                                        new Employee("paula pres", new Decimal(20000)),
                                    };
            Decimal expenseReportAmount;
            string line = null;
            do
            {
                Console.WriteLine("Enter the expense report amount");
                line = Console.ReadLine();
                if(line != null)
                {
                    expenseReportAmount = Convert.ToDecimal(line);
                    IExpenseReport expense = new ExpenseReport(expenseReportAmount);
                    bool expenseProssed = false;

                    foreach (Employee approver in managers)
                    {
                        ApprovalResponse response = approver.ApproveExpense(expense);

                        if (response != ApprovalResponse.BeyondApprovalLimit)
                        {
                            Console.WriteLine("The request was {0}.", response);
                            expenseProssed = true;
                            break;
                        }
                    }
                    if (!expenseProssed)
                    {
                        Console.WriteLine("No one was able to approve your expense.");
                    }
                }
            }
            while(line != null);
        }
    }
}
