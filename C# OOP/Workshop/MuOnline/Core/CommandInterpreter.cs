namespace MuOnline.Core
{
    using MuOnline.Core.Contracts;
    using System;
    using System.Linq;

    public class CommandInterpreter : ICommandInterpreter
    {
        private const string Suffix = "command";
        private readonly IServiceProvider serviceProvider;

        public string Read(string[] args)
        {
            //AddItem itemName

            string commandName = args[0];
            string[] inputArgs = args.Skip(1).ToArray();

            //find types
            //

            //read
            //instance
            //invoke
            //return result

            return null;
        }
    }
}
