namespace MortalEngines.Core
{
    using Contracts;
    using MortalEngines.Common;
    using MortalEngines.Entities.Contracts;
    using MortalEngines.Models;
    using MortalEngines.Repositories;
    using System.Text;

    public class MachinesManager : IMachinesManager
    {
        private PilotRepository pilotRepository;
        private MachineRepository machineRepository;

        public MachinesManager()
        {
            this.pilotRepository = new PilotRepository();
            this.machineRepository = new MachineRepository();
        }

        public string HirePilot(string name)
        {
            if (pilotRepository.Contains(name))
            {
                return string.Format(OutputMessages.PilotExists, name);
            }
               
            Pilot pilot = new Pilot(name);

            pilotRepository.Add(pilot);

            return string.Format(OutputMessages.PilotHired, name);
        }

        public string ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            if (machineRepository.Contains(name))
            {
                return string.Format(OutputMessages.MachineExists, name);
            }
            
            Tank tank = new Tank(name, attackPoints, defensePoints);

            machineRepository.Add(tank);

            return string.Format(OutputMessages.TankManufactured, name, tank.AttackPoints, tank.DefensePoints);
        }

        public string ManufactureFighter(string name, double attackPoints, double defensePoints)
        {
            if (machineRepository.Contains(name))
            {
                return string.Format(OutputMessages.MachineExists, name);
            }

            Fighter fighter = new Fighter(name, attackPoints, defensePoints);

            machineRepository.Add(fighter);

            return string.Format(OutputMessages.FighterManufactured, name, fighter.AttackPoints, 
                fighter.DefensePoints, fighter.AggressiveModeToString());
        }

        public string EngageMachine(string selectedPilotName, string selectedMachineName)
        {
            if(!pilotRepository.Contains(selectedPilotName))
            {
                return string.Format(OutputMessages.PilotNotFound, selectedPilotName);
            }

            if(!machineRepository.Contains(selectedMachineName))
            {
                return string.Format(OutputMessages.MachineNotFound, selectedMachineName);
            }

            var machine = machineRepository.Get(selectedMachineName);

            if(machine.Pilot != null)
            {
                return string.Format(OutputMessages.MachineHasPilotAlready, selectedMachineName);
            }

            var pilot = pilotRepository.Get(selectedPilotName);

            pilot.AddMachine(machine);

            machine.Pilot = pilot;

            return string.Format(OutputMessages.MachineEngaged, selectedPilotName, selectedMachineName);
        }

        public string AttackMachines(string attackingMachineName, string defendingMachineName)
        {
            throw new System.NotImplementedException();
        }

        public string PilotReport(string pilotReporting)
        {
            if (pilotRepository.Contains(pilotReporting))
            {
                var pilot = pilotRepository.Get(pilotReporting);

                return (pilot.Report());
            }

            return string.Format(OutputMessages.PilotNotFound, pilotReporting);
        }

        public string MachineReport(string machineName)
        {
            if(machineRepository.Contains(machineName))
            {
                var machine = machineRepository.Get(machineName);

                return machine.ToString();
            }

            return string.Format(OutputMessages.MachineNotFound, machineName);
        }

        public string ToggleFighterAggressiveMode(string fighterName)
        {
            if (machineRepository.Contains(fighterName))
            {
                var fighter = (IFighter)machineRepository.Get(fighterName);

                fighter.ToggleAggressiveMode();

                return string.Format(OutputMessages.FighterOperationSuccessful, fighterName);
            }

            return string.Format(OutputMessages.MachineNotFound, fighterName);
        }

        public string ToggleTankDefenseMode(string tankName)
        {
            if(machineRepository.Contains(tankName))
            {
                var tank = (ITank)machineRepository.Get(tankName);

                tank.ToggleDefenseMode();

                return string.Format(OutputMessages.TankOperationSuccessful, tankName);
            }

            return string.Format(OutputMessages.MachineNotFound, tankName);
        }
    }
}