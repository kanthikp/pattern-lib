using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command.Pattern._1
{
    public interface ICommandFactory
    {
        string CommandName { get; }
        string Description { get; }
        ICommand MakeCommand(string[] arguments);
    }
}
