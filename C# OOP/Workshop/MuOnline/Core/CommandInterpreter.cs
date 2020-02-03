namespace MuOnline.Core
{
    using MuOnline.Core.Commands.Contracts;
    using MuOnline.Core.Contracts;
    using System;
    using System.Linq;
    using System.Reflection;

    public class CommandInterpreter : ICommandInterpreter
    {
        private const string suffix = "command";
        private readonly IServiceProvider serviceProvider;

        public CommandInterpreter(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public string Read(string[] args)
        {
            //AddItem itemName

            string commandName = args[0].ToLower() + suffix;
            string[] inputArgs = args.Skip(1).ToArray();

            //find types

            var type = Assembly.GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name.ToLower() == commandName);

            if(type == null)
            {
                throw new ArgumentNullException("Invalid Command!");
            }

            var constructor = type
                .GetConstructors()
                .FirstOrDefault();

            var constructorParams = constructor
                .GetParameters()
                .Select(p => p.ParameterType)
                .ToArray();

            var services = constructorParams
                .Select(this.serviceProvider.GetService)
                .ToArray();

            var typeInstance = (ICommand)Activator.CreateInstance(type, services);

            var result = typeInstance.Execute(inputArgs);

            return result;
        }
    }
}
