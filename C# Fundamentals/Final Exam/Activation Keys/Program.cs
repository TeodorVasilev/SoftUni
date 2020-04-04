namespace Activation_Keys
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            char[] rawKey = Console.ReadLine().ToCharArray();

            string input = Console.ReadLine();

            while (input != "Generate")
            {
                string[] instructions = input.Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                string command = instructions[0];

                if(command == "Contains")
                {
                    string sub = instructions[1];

                    if(new string(rawKey).Contains(sub))
                    {
                        Console.WriteLine($"{new string(rawKey)} contains {sub}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if(command == "Flip")
                {
                    string type = instructions[1];
                    int start = int.Parse(instructions[2]);
                    int end = int.Parse(instructions[3]);

                    if (type == "Upper")
                    {
                        for (int i = start; i < end; i++)
                        {
                            rawKey[i] = char.ToUpper(rawKey[i]);
                        }
                    }
                    else if(type == "Lower")
                    {
                        for (int i = start; i < end; i++)
                        {
                            rawKey[i] = char.ToLower(rawKey[i]);
                        }
                    }

                    Console.WriteLine(new string(rawKey));
                }
                else if(command == "Slice")
                {
                    int start = int.Parse(instructions[1]);
                    int end = int.Parse(instructions[2]);

                    List<char> temp = rawKey.ToList();

                    temp.RemoveRange(start, end - start);

                    rawKey = temp.ToArray();

                    Console.WriteLine(new string(rawKey));
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {new string(rawKey)}");
        }
    }
}
