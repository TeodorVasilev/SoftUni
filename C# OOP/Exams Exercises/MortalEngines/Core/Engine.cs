namespace MortalEngines.Core
{
    using MortalEngines.Core.Contracts;
    using MortalEngines.IO;
    using MortalEngines.IO.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Engine : IEngine
    {
        private MachinesManager machinesManager;
        private CommandInterpreter commandInterpreter;
        private IWriter consoleWriter;

        public Engine()
        {
            this.machinesManager = new MachinesManager();
            this.commandInterpreter = new CommandInterpreter();
            this.consoleWriter = new ConsoleWriter();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (true)
            {
                try
                {
                    string[] inputArgs = input.Split();

                    string result = this.commandInterpreter.Read(inputArgs);

                    this.consoleWriter.Write(result);

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
