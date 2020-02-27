namespace Number_Array
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] commandArgs = input.Split();

                string command = commandArgs[0];

                if(command == "Switch")
                {
                    int index = int.Parse(commandArgs[1]);

                    if (index >= 0 && index < numbers.Length)
                    {
                        if(numbers[index] != 0)
                        {
                            if(numbers[index] < 0)
                            {
                                numbers[index] = Math.Abs(numbers[index]);
                            }
                            else
                            {
                                numbers[index] *= -1;
                            }
                        }
                    }
                }
                else if(command == "Change")
                {
                    int index = int.Parse(commandArgs[1]);
                    int value = int.Parse(commandArgs[2]);

                    if (index >= 0 && index < numbers.Length)
                    {
                        numbers[index] = value;
                    }
                }
                else if(command == "Sum")
                {
                    if(commandArgs[1] == "Negative")
                    {
                        int negativeSum = 0;

                        for (int i = 0; i < numbers.Length; i++)
                        {
                            if(numbers[i] < 0)
                            {
                                negativeSum += numbers[i];
                            }
                        }

                        Console.WriteLine(negativeSum);
                    }
                    else if(commandArgs[1] == "Positive")
                    {
                        int positiveSum = 0;

                        for (int i = 0; i < numbers.Length; i++)
                        {
                            if(numbers[i] > 0)
                            {
                                positiveSum += numbers[i];
                            }
                        }

                        Console.WriteLine(positiveSum);
                    }
                    else if(commandArgs[1] == "All")
                    {
                        Console.WriteLine(numbers.Sum());
                    }
                }

                input = Console.ReadLine();
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] >= 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
