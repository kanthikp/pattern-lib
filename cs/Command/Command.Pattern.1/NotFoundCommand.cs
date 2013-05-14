using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command.Pattern._1
{
    public class NotFoundCommand : ICommand, ICommandFactory
    {
        public void Execute()
        {
            Console.WriteLine(string.Format("LOG: Command not found {0}",Name));
        }

        public string CommandName
        {
            get { return "NotFoundCommand"; }
        }

        public string Description
        {
            get { return "Command not found"; }
        }

        public ICommand MakeCommand(string[] arguments)
        {
            return new NotFoundCommand { Name = arguments[1] };
        }

        public string Name { get; set; }
    }
}
