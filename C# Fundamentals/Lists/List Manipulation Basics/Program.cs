namespace List_Manipulation_Basics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputArgs = input.Split();

                if(inputArgs[0] == "Add")
                {
                    numbers.Add(int.Parse(inputArgs[1]));
                }
                else if(inputArgs[0] == "Remove")
                {
                    numbers.Remove(int.Parse(inputArgs[1]));
                }
                else if (inputArgs[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(inputArgs[1]));
                }
                else if(inputArgs[0] == "Insert")
                {
                    numbers.Insert(int.Parse(inputArgs[2]), int.Parse(inputArgs[1]));
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
