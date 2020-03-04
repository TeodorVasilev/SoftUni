using System;
using System.Linq;

namespace Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split("@").Select(int.Parse).ToArray();

            string input = Console.ReadLine();

            int startIndex = 0;

            while (input != "Love!")
            {
                string[] commandArgs = input.Split();

                string command = commandArgs[0];
                
                if(command == "Jump")
                {
                    int length = int.Parse(commandArgs[1]);

                    startIndex += length;

                    if(startIndex < numbers.Length)
                    {
                        if (numbers[startIndex] == 0)
                        {
                            Console.WriteLine($"Place {startIndex} already had Valentine's day.");
                            //startIndex = startIndex + length;
                            input = Console.ReadLine();
                            continue;
                        }

                        numbers[startIndex] -= 2;

                        if(numbers[startIndex] == 0)
                        {
                            Console.WriteLine($"Place {startIndex} has Valentine's day.");
                        }
                    }
                    else
                    {
                        startIndex = 0;

                        if (numbers[startIndex] == 0)
                        {
                            Console.WriteLine($"Place {startIndex} already had Valentine's day.");
                            //startIndex = startIndex + length;
                            input = Console.ReadLine();
                            continue;
                        }

                        numbers[0] -= 2;

                        if (numbers[startIndex] == 0)
                        {
                            Console.WriteLine($"Place {startIndex} has Valentine's day.");
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {startIndex}.");

            int valentineHouses = 0;
            int notValentineHouses = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] <= 0)
                {
                    valentineHouses++;
                }
                else
                {
                    notValentineHouses++;
                }
            }

            if(notValentineHouses != 0)
            {
                Console.WriteLine($"Cupid has failed {notValentineHouses} places.");
            }
            else
            {
                Console.WriteLine("Mission was successful.");
            }
        }
    }
}
