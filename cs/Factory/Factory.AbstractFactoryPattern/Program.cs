using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Factory.AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ITreeFactory factory = LoadFactory();

            Print("Small tree");
            var tree = factory.CreateSmallTree();
            tree.Grows();
            tree.Dies();
            
            Print("Big tree");
            tree = factory.CreateBigTree();
            tree.Grows();
            tree.Dies();

            Print("Old tree");
            tree = factory.CreateOldTree();
            tree.Grows();
            tree.Dies();


        }
        static ITreeFactory LoadFactory()
        {                                 
            string factoryName = Properties.Settings.Default.TreeFactory;
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as ITreeFactory;
        }
        static void Print(string s)
        {
            Console.WriteLine("-----------------{0}----------------------",s);
        }
    }
}
