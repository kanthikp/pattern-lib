using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command.Pattern._1
{
    public class ShipOrderCommand : ICommand, ICommandFactory
    {
        public void Execute()
        {   
            Console.WriteLine("LOG: Ship Order Command");
        }

        public string CommandName { get { return "ShipOrder"; } }

        public string Description { get { return "ShipOrder description"; } }

        public ICommand MakeCommand(string[] arguments)
        {
            return new ShipOrderCommand();
        }
    }
}
