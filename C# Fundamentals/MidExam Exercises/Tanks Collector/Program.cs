namespace Tanks_Collector
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> tanks = Console.ReadLine().Split(", ").ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine().Split(", ");

                string command = commandArgs[0];

                if(command == "Add")
                {
                    string tankName = commandArgs[1];

                    if(!tanks.Contains(tankName))
                    {
                        tanks.Add(tankName);

                        Console.WriteLine("Tank successfully bought");
                    }
                    else
                    {
                        Console.WriteLine("Tank is already bought");
                    }
                }
                else if(command == "Remove")
                {
                    string tankName = commandArgs[1];

                    if(!tanks.Contains(tankName))
                    {
                        Console.WriteLine("Tank not found");
                    }
                    else
                    {
                        tanks.Remove(tankName);
                        Console.WriteLine("Tank successfully sold");
                    }
                }
                else if (command == "Remove At")
                {
                    int index = int.Parse(commandArgs[1]);

                    if(ValidateIndex(index, tanks))
                    {
                        tanks.RemoveAt(index);
                        Console.WriteLine("Tank successfully sold");
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(commandArgs[1]);
                    string tankName = commandArgs[2];

                    if (ValidateIndex(index, tanks))
                    {
                        if(!tanks.Contains(tankName))
                        {
                            tanks.Insert(index, tankName);
                            Console.WriteLine("Tank successfully bought");
                        }
                        else
                        {
                            Console.WriteLine("Tank is already bought");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
            }

            Console.WriteLine(string.Join(", ", tanks));
        }

        static bool ValidateIndex(int index, List<string> tanks)
        {
            if (index >= 0 && index < tanks.Count)
            {
                return true;
            }

            return false;
        }
    }
}