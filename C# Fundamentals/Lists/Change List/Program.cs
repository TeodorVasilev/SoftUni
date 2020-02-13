namespace Change_List
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

                if(inputArgs[0] == "Delete")
                {
                    int element = int.Parse(inputArgs[1]);

                    while (numbers.Contains(element))
                    {
                        numbers.Remove(element);
                    }
                }
                else if(inputArgs[0] == "Insert")
                {
                    int element = int.Parse(inputArgs[1]);
                    int index = int.Parse(inputArgs[2]);

                    numbers.Insert(index, element);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
