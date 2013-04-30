using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor.Pattern._1
{
    public interface IVisitor
    {
        void Visit(RealEstate realEstate);
        void Visit(BankAccount bankAccount);
        void Visit(Loan loan);
    }
    public interface IAsset
    {
        void Accept(IVisitor visitor);
    }
    public class NetWorthVisitor : IVisitor 
    {
        public int Total { get; set; }

        public void Visit(RealEstate realEstate)
        {
            Total += realEstate.EstimatedValue;
        }

        public void Visit(BankAccount bankAccount)
        {
            Total += bankAccount.Amount;
        }

        public void Visit(Loan loan)
        {
            Total -= loan.Owed;
        }
    }
    public class Person: IAsset
    {
        public List<IAsset> Assets= new List<IAsset>();

        public void Accept(IVisitor visitor)
        {
            foreach (var asset in Assets)
                asset.Accept(visitor);
        }
    }
    public class Loan : IAsset
    {
        public int Owed { get; set; }
        public int MonthlyPayment { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
    public class BankAccount : IAsset
    {
        public int Amount { get; set; }
        public double MonthlyInterest { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
    public class RealEstate: IAsset
    {
        public int EstimatedValue { get; set; }
        public int MonthlyRent { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
