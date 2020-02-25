namespace Archery_Tournament
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] field = Console.ReadLine().Split("|").Select(int.Parse).ToArray();

            string input = Console.ReadLine();

            int points = 0;

            while (input != "Game over")
            {
                string[] commandArgs = input.Split(' ', '@');

                if(commandArgs[0] == "Reverse")
                {
                    Array.Reverse(field);
                    input = Console.ReadLine();
                    continue;
                }

                string direction = commandArgs[1];
                int startIndex = int.Parse(commandArgs[2]);

                if(startIndex > field.Length || startIndex < 0)
                {
                    input = Console.ReadLine();
                    continue;
                }

                int length = int.Parse(commandArgs[3]);


                if(direction == "Left")
                {
                    int count = 0;
                    int index = startIndex;

                    while (count != length)
                    {
                        count++;
                        index--;

                        if(index < 0)
                        {
                            index = field.Length - 1;
                        }
                    }

                    if(field[index] >= 5)
                    {
                        field[index] -= 5;
                        points += 5;
                    }
                    else
                    {
                        points += field[index];
                        field[index] = 0;
                    }
                }
                else if(direction == "Right")
                {
                    int count = 0;
                    int index = startIndex;

                    while (count != length)
                    {
                        count++;
                        index++;

                        if (index > field.Length - 1)
                        {
                            index = 0;
                        }
                    }

                    if (field[index] >= 5)
                    {
                        field[index] -= 5;
                        points += 5;
                    }
                    else
                    {
                        points += field[index];
                        field[index] = 0;
                    }
                }

                
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" - ", field));
            Console.WriteLine($"Iskren finished the archery tournament with {points} points!");
        }
    }
}
