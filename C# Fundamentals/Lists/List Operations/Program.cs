namespace List_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = "";

            while (input != "End")
            {
                input = Console.ReadLine();
                string[] inputArgs = input.Split();
                string command = inputArgs[0];

                if (command == "Add")
                {
                    int number = int.Parse(inputArgs[1]);
                    numbers.Add(number);
                }
                else if (command == "Insert")
                {
                    int number = int.Parse(inputArgs[1]);
                    int index = int.Parse(inputArgs[2]);

                    if (index < 0 || index > numbers.Count - 1)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.Insert(index, number);
                }
                else if (command == "Remove")
                {
                    int index = int.Parse(inputArgs[1]);

                    if (index < 0 || index > numbers.Count - 1)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.RemoveAt(index);
                }
                else if (command == "Shift")
                {
                    if (inputArgs[1] == "left")
                    {
                        int rotations = int.Parse(inputArgs[2]);

                        for (int i = 0; i < rotations; i++)
                        {
                            int firstNumber = numbers[0];

                            for (int k = 0; k < numbers.Count - 1; k++)
                            {
                                numbers[k] = numbers[k + 1];
                            }

                            numbers[numbers.Count - 1] = firstNumber;
                        }
                    }
                    else if(inputArgs[1] == "right")
                    {
                        int rotations = int.Parse(inputArgs[2]);

                        for (int i = 0; i < rotations; i++)
                        {
                            int lastNumber = numbers[numbers.Count - 1];

                            for (int k = numbers.Count - 1; k > 0; k--)
                            {
                                numbers[k] = numbers[k - 1];
                            }

                            numbers[0] = lastNumber;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
