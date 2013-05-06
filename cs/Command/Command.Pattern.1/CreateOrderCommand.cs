using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command.Pattern._1
{
    public class CreateOrderCommand : ICommand, ICommandFactory
    {
        public void Execute()
        {
            Console.WriteLine("LOG: Create Order Command");
        }

        public string CommandName { get { return "CreateOrder"; } }

        public string Description { get { return "CreateOrder description"; } }

        public ICommand MakeCommand(string[] arguments)
        {
            return new CreateOrderCommand();
        }
    }
}
