using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace Singleton.Pattern._1
{
    public class Program
    {      
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton 1:"); 
            Singleton sing = Singleton.Instance;
            sing.DisplayMessage();
            sing.DisplayMessage();
            Console.WriteLine("Singleton 2:"); 
            Singleton sing2 = Singleton.Instance;
            sing2.DisplayMessage();
            Console.ReadLine();
        }

    }

    public class Singleton
    {
       private static Singleton instance;

       private Singleton() { Console.WriteLine("Constructor Singleton"); }

       public static Singleton Instance
       {
          get 
          {
             if (instance == null)
             {
                instance = new Singleton();
             }
             return instance;
          }
       }
       public void DisplayMessage()
        {
            Console.WriteLine("Singleton msg");
        }
    }
}
