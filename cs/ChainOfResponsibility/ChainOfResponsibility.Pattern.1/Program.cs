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
            ExpenseHandler will = new ExpenseHandler(new Employee("will worker", Decimal.Zero));
            ExpenseHandler mary = new ExpenseHandler(new Employee("mary manager", new Decimal(1000)));
            ExpenseHandler victor = new ExpenseHandler(new Employee("victor vpres", new Decimal(5000)));
            ExpenseHandler paula = new ExpenseHandler(new Employee("paula pres", new Decimal(20000)));

            will.RegisterNext(mary);
            mary.RegisterNext(victor);
            victor.RegisterNext(paula);

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

                    ApprovalResponse response = will.Approve(expense);
                    Console.WriteLine("The request was {0}.", response);
                }
            }
            while(line != null);
        }
    }
}
