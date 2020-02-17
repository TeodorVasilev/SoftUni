namespace MortalEngines.Core
{
    using MortalEngines.Core.Contracts;
    using System;
    using System.Linq;

    public class CommandInterpreter : ICommandInterpreter
    {
        private MachinesManager machinesManager;

        public CommandInterpreter()
        {
            this.machinesManager = new MachinesManager();
        }

        public string Read(string[] args)
        {
            string command = args[0];
            string[] inputArgs = args.Skip(1).ToArray();

            string result = string.Empty;

            if(command == "HirePilot")
            {
                string name = inputArgs[0];

                result = machinesManager.HirePilot(name);
            }
            else if(command == "PilotReport")
            {
                string name = inputArgs[0];

                result = machinesManager.PilotReport(name);
            }
            else if(command == "ManufactureTank")
            {
                string name = inputArgs[0];
                double attack = double.Parse(inputArgs[1]);
                double defense = double.Parse(inputArgs[2]);

                result = machinesManager.ManufactureTank(name, attack, defense);
            }
            else if(command == "ManufactureFighter")
            {
                string name = inputArgs[0];
                double attack = double.Parse(inputArgs[1]);
                double defense = double.Parse(inputArgs[2]);

                result = machinesManager.ManufactureFighter(name, attack, defense);
            }
            else if(command == "MachineReport")
            {
                string name = inputArgs[0];

                result = machinesManager.MachineReport(name);
            }
            else if(command == "AggressiveMode")
            {
                string name = inputArgs[0];

                result = machinesManager.AggressiveMode(name);
            }
            else if(command == "DefenseMode")
            {
                string name = inputArgs[0];

                result = machinesManager.DefenseMode(name);
            }
            else if(command == "Engage")
            {
                string name = inputArgs[0];
                string machineName = inputArgs[1];

                result = machinesManager.Engage(name, machineName);
            }
            else if(command == "Attack")
            {
                string attackingName = inputArgs[0];
                string defendingName = inputArgs[1];

                result = machinesManager.Attack(attackingName, defendingName);
            }
            else if(command == "Quit")
            {
                Environment.Exit(0);
            }

            return result;
        }
    }
}
