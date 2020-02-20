namespace Froggy_Squad
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> frogNames = Console.ReadLine().Split().ToList();

            while (true)
            {
                string[] inputArgs = Console.ReadLine().Split();

                string command = inputArgs[0];

                if(command == "Join")
                {
                    string name = inputArgs[1];
                    frogNames.Add(name);
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

                    if (count > frogNames.Count - 1)
                    {
                        Console.WriteLine(string.Join(" ", frogNames));
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            Console.Write(frogNames[i] + " ");
                        }
                    }
                }
                else if(command == "Last")
                {
                    int count = int.Parse(inputArgs[1]);

                    if(count > frogNames.Count - 1)
                    {
                        Console.WriteLine(string.Join(" ", frogNames));
                    }
                    else
                    {
                        List<string> temp = new List<string>();

                        for (int i = frogNames.Count - 1; i > count + 1; i--)
                        {
                            temp.Add(frogNames[i]);
                        }

                        temp.Reverse();

                        Console.WriteLine(string.Join(" ", temp));
                    }

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
