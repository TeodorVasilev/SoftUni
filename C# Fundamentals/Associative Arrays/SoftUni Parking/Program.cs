namespace SoftUni_Parking
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> nameNumber = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine().Split();

                string command = commandArgs[0];
                

                if(command == "register")
                {
                    string name = commandArgs[1];
                    string number = commandArgs[2];

                    if (!nameNumber.ContainsKey(name))
                    {
                        nameNumber[name] = number;

                        Console.WriteLine($"{name} registered {number} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {nameNumber[name]}");
                    }
                }
                else if(command == "unregister")
                {
                    string name = commandArgs[1];

                    if (!nameNumber.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        nameNumber.Remove(name);

                        Console.WriteLine($"{name} unregistered successfully");
                    }
                }
            }

            foreach (var kvp in nameNumber)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
