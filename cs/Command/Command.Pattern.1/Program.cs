﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command.Pattern._1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                PrintUsage();
                return;
            }
            var processor = new CommandExecutor();
            processor.ExecuteCommand(args);
        }
        private static void PrintUsage()
        {
            Console.WriteLine("Usage: LoggingDemo CommandName Arguments");
            Console.WriteLine("Commands:");
            Console.WriteLine("     UpdateQuantity number");
            Console.WriteLine("     CreateOrder");
            Console.WriteLine("     ShipOrder");
        }
    }
}
