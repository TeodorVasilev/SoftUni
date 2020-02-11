namespace MortalEngines.Core
{
    using MortalEngines.Core.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Engine : IEngine
    {
        private MachinesManager machinesManager;
        private CommandInterpreter commandInterpreter;

        public Engine()
        {
            this.machinesManager = new MachinesManager();
            this.commandInterpreter = new CommandInterpreter();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "Quit")
            {
                try
                {
                    string[] inputArgs = input.Split();

                    string result = this.commandInterpreter.Read(inputArgs);

                    input = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
