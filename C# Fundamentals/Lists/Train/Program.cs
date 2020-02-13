namespace Train
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();

            int wagonMaxCapacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputArgs = input.Split();

                if(inputArgs[0] == "Add")
                {
                    int passengers = int.Parse(inputArgs[1]);

                    wagons.Add(passengers);
                }
                else
                {
                    int passengers = int.Parse(inputArgs[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if(wagons[i] + passengers <= wagonMaxCapacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
