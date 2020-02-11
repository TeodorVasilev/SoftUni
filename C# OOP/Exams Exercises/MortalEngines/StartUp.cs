namespace MortalEngines
{
    using MortalEngines.Core;
    using MortalEngines.Models;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Fighter fighter = new Fighter("ME-109-BF", 250, 156);

            //Console.WriteLine(fighter);

            Tank tank = new Tank("Jagdt-Panther", 300, 300);

           //Console.WriteLine(tank);

            //Pilot pilot = new Pilot("Red Baron");

            //pilot.AddMachine(fighter);
            //pilot.AddMachine(tank);

            //Console.WriteLine(pilot.Report());

            MachinesManager machinesManager = new MachinesManager();

            //Console.WriteLine(machinesManager.HirePilot("Red Baron"));
            //Console.WriteLine(machinesManager.HirePilot("Red Baron"));
            //Console.WriteLine(machinesManager.PilotReport("Red Baron"));
            //Console.WriteLine(machinesManager.ManufactureTank("Jagdt-Panther", 100, 100));
            //Console.WriteLine(machinesManager.ManufactureTank("Jagdt-Panther", 200, 200));
            //Console.WriteLine(machinesManager.ManufactureFighter("ME-262", 100, 100));
            //Console.WriteLine(machinesManager.ManufactureFighter("ME-262", 100, 100));
            //Console.WriteLine(machinesManager.PilotReport("Gergi"));
            //Console.WriteLine(machinesManager.MachineReport("Na gergi busa"));
            //Console.WriteLine(machinesManager.ToggleFighterAggressiveMode("ME-262"));
            //Console.WriteLine(machinesManager.ToggleTankDefenseMode("Jagdt-Panther"));
            //Console.WriteLine(machinesManager.MachineReport("ME-262"));
            //Console.WriteLine(machinesManager.MachineReport("Jagdt-Panther"));

            //TODO FIX POINTS WHEN CHANGING MODES
            //Toggle Aggressive/Defence Mode
            //Console.WriteLine(machinesManager.ManufactureTank("A", 100, 100));
            //Console.WriteLine(machinesManager.ToggleTankDefenseMode("A"));
            //Console.WriteLine(machinesManager.MachineReport("A"));
            //Console.WriteLine(machinesManager.ToggleTankDefenseMode("A"));
            //Console.WriteLine(machinesManager.MachineReport("A"));

            //Console.WriteLine(machinesManager.ManufactureFighter("B", 100, 100));
            //Console.WriteLine(machinesManager.ToggleFighterAggressiveMode("B"));
            //Console.WriteLine(machinesManager.MachineReport("B"));
            //Console.WriteLine(machinesManager.ToggleFighterAggressiveMode("B"));
            //Console.WriteLine(machinesManager.MachineReport("B"));

            //Engage machine
            //Console.WriteLine(machinesManager.HirePilot("Red Baron"));
            //Console.WriteLine(machinesManager.ManufactureTank("Jagdt-Panther", 100, 100));
            //Console.WriteLine(machinesManager.EngageMachine("Red Baron", "Jagdt-Panther"));
            //Console.WriteLine(machinesManager.HirePilot("Red Baron2"));
            //Console.WriteLine(machinesManager.EngageMachine("Red Baron23", "Jagdt-Panther"));

        }
    }
}