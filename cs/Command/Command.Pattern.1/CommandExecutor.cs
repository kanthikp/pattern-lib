using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command.Pattern._1
{
    public class CommandExecutor
    {
        internal void ExecuteCommand(string[] args)
        {
            switch (args[0])
            { 
                case "UpdateQuantity":
                    UpdateQuantity(int.Parse(args[1]));
                    break;
                case "CreateOrder":
                    CreateOrder();
                    break;
                case "ShipOrder":
                    ShipOrder();
                    break;
                default:
                    Console.WriteLine("Unrecognized command");
                    break;
            }
        }

        private void UpdateQuantity(int 
            newQuantity)
        {
            const int oldQuantity = 5;
            Console.WriteLine("DATABASE: Updated");

            Console.WriteLine("LOG: Updated order quantity from {0} to {1}",oldQuantity,newQuantity);
        }
        private void ShipOrder()
        {
            throw new NotImplementedException();
        }

        private void CreateOrder()
        {
            throw new NotImplementedException();
        }
    }
}
