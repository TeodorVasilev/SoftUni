namespace Froggy_Squad
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> frogNames = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                string[] inputArgs = Console.ReadLine().Split();

                string command = inputArgs[0];

                if(command == "Join")
                {
                    string name = inputArgs[1];

                    if(!frogNames.Contains(name))
                    {
                        frogNames.Add(name);
                    }
                }
                else if(command == "Jump")
                {
                    string name = inputArgs[1];
                    int index = int.Parse(inputArgs[2]);

                    if(IsIndexValid(frogNames, index))
                    {
                        frogNames.Insert(index, name);
                    }
                }
                else if(command == "Dive")
                {
                    int index = int.Parse(inputArgs[1]);

                    if(IsIndexValid(frogNames, index))
                    {
                        frogNames.RemoveAt(index);
                    }
                }
                else if(command == "First")
                {
                    int count = int.Parse(inputArgs[1]);

                    if(count >= frogNames.Count)
                    {
                        count = frogNames.Count;
                    }

                    List<string> temp = new List<string>();

                    temp = frogNames.Take(count).Select(x => x).ToList();

                    Console.WriteLine(string.Join(" ", temp));
                }
                else if(command == "Last")
                {
                    int count = int.Parse(inputArgs[1]);

                    if (count >= frogNames.Count)
                    {
                        count = frogNames.Count;
                    }

                    List<string> temp = new List<string>();

                    frogNames.Reverse();

                    temp = frogNames.Take(count).Select(x => x).ToList();

                    temp.Reverse();

                    frogNames.Reverse();

                    Console.WriteLine(string.Join(" ", temp));
                }
                else if(command == "Print")
                {
                    if(inputArgs[1] == "Normal")
                    {
                        Console.WriteLine($"Frogs: {string.Join(" ", frogNames)}");
                        return;
                    }
                    else if(inputArgs[1] == "Reversed")
                    {
                        frogNames.Reverse();

                        Console.WriteLine($"Frogs: {string.Join(" ", frogNames)}");
                        return;
                    }
                }
            }
        }

        static bool IsIndexValid(List<string> frogNames, int index)
        {
            if (index < frogNames.Count - 1 && index >= 0)
            {
                return true;
            }

            return false;
        }
    }
}
