namespace MortalEngines.Core
{
    using MortalEngines.Core.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string[] args)
        {
            string commandName = args[0];
            string[] inputArgs = args.Skip(1).ToArray();

        }
    }
}
