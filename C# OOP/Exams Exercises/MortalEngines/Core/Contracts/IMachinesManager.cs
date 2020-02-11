namespace MortalEngines.Core.Contracts
{
    public interface IMachinesManager
    {
        string HirePilot(string name);

        string ManufactureTank(string name, double attackPoints, double defensePoints);

        string ManufactureFighter(string name, double attackPoints, double defensePoints);

        //EngageMachine
        string Engage(string selectedPilotName, string selectedMachineName);

        //AttackMachines
        string Attack(string attackingMachineName, string defendingMachineName);

        string PilotReport(string pilotReporting);

        string MachineReport(string machineName);
        //ToggleFighterAggressiveMode
        string AggressiveMode(string fighterName);

        //ToggleTankDefenseMode
        string DefenseMode(string tankName);
    }
}