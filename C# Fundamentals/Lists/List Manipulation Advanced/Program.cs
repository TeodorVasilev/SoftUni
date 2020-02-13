namespace List_Manipulation_Advanced
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

            bool isChanged = false;

            while (input != "end")
            {
                string[] inputArgs = input.Split();

                if (inputArgs[0] == "Add")
                {
                    numbers.Add(int.Parse(inputArgs[1]));
                    isChanged = true;
                }
                else if (inputArgs[0] == "Remove")
                {
                    numbers.Remove(int.Parse(inputArgs[1]));
                    isChanged = true;
                }
                else if (inputArgs[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(inputArgs[1]));
                    isChanged = true;
                }
                else if (inputArgs[0] == "Insert")
                {
                    numbers.Insert(int.Parse(inputArgs[2]), int.Parse(inputArgs[1]));
                    isChanged = true;
                }
                else if (inputArgs[0] == "Contains")
                {
                    if (numbers.Contains(int.Parse(inputArgs[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (inputArgs[0] == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
                }
                else if (inputArgs[0] == "PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));
                }
                else if (inputArgs[0] == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (inputArgs[0] == "Filter")
                {
                    string condition = inputArgs[1];
                    int number = int.Parse(inputArgs[2]);

                    if(condition == "<")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x < number)));
                    }
                    else if(condition == ">")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x > number)));
                    }
                    else if(condition =="<=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x <= number)));
                    }
                    else if(condition == ">=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x >= number)));
                    }
                }

                input = Console.ReadLine();
            }

            if(isChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
