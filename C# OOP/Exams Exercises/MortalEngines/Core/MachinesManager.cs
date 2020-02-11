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

        public string Engage(string selectedPilotName, string selectedMachineName)
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

        //output messages
        //if one of the machines doesn't exist, the attacking machine is with priority????????
        //--if the two machines doesn't exist print Atacking machne name!?

        //if one of the machines has health equal to zero, the attacking machine is with priority???????
        //--if the two machines health are equal to zero, print the attacking machine name!?

        //When machine is dead?
        //--if machine currentHealth is zero -- is DEAD!?
        //NOT SURE TEST!
        public string Attack(string attackingMachineName, string defendingMachineName)
        {
            if (!machineRepository.Contains(attackingMachineName) && !machineRepository.Contains(defendingMachineName))
            {
                return string.Format(OutputMessages.MachineNotFound, attackingMachineName);
            }
            else if(!machineRepository.Contains(attackingMachineName))
            {
                return string.Format(OutputMessages.MachineNotFound, attackingMachineName);
            }
            else if(!machineRepository.Contains(defendingMachineName))
            {
                return string.Format(OutputMessages.MachineNotFound, defendingMachineName);
            }

            var attackingMachine = machineRepository.Get(attackingMachineName);
            var defendingMachine = machineRepository.Get(defendingMachineName);

            if(attackingMachine.HealthPoints <= 0 && defendingMachine.HealthPoints <= 0)
            {
                return string.Format(OutputMessages.DeadMachineCannotAttack, attackingMachineName);
            }
            else if(attackingMachine.HealthPoints <= 0)
            {
                return string.Format(OutputMessages.DeadMachineCannotAttack, attackingMachineName);
            }
            else if(defendingMachine.HealthPoints <= 0)
            {
                return string.Format(OutputMessages.DeadMachineCannotAttack, defendingMachineName);
            }

            attackingMachine.Attack(defendingMachine);

            return string.Format(OutputMessages.AttackSuccessful, defendingMachineName, attackingMachineName, defendingMachine.HealthPoints);
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

        public string AggressiveMode(string fighterName)
        {
            if (machineRepository.Contains(fighterName))
            {
                var fighter = (IFighter)machineRepository.Get(fighterName);

                fighter.ToggleAggressiveMode();

                return string.Format(OutputMessages.FighterOperationSuccessful, fighterName);
            }

            return string.Format(OutputMessages.MachineNotFound, fighterName);
        }

        public string DefenseMode(string tankName)
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