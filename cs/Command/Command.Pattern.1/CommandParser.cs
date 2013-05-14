using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command.Pattern._1
{
    public class CommandParser
    {
        readonly IEnumerable<ICommandFactory> availableCommands;

        public CommandParser(IEnumerable<ICommandFactory> availableCommands)
        {
            this.availableCommands = availableCommands;
        }

        internal ICommand ParseCommand(string[] args)
        {
            var requestedCommandName = args[0];
            var command = FindRequestedCommand(requestedCommandName);
            if (null == command)
                return new NotFoundCommand{Name = requestedCommandName};
            return command.MakeCommand(args);
        }

        ICommandFactory FindRequestedCommand(string cmdName)
        {
            return availableCommands.FirstOrDefault(cmd => cmd.CommandName == cmdName);
        }
    }
}
