namespace Weaponsmith
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string[] particles = Console.ReadLine().Split("|");

            string input = Console.ReadLine();

            while (input != "Done")
            {
                string[] commandArgs = input.Split();

                string command = commandArgs[0];

                if(command == "Move")
                {
                    int index = int.Parse(commandArgs[2]);
                    string direction = commandArgs[1];

                    if(direction == "Left")
                    {
                        if(ValidateIndex(index, direction, particles))
                        {
                            string temp = particles[index - 1];
                            particles[index - 1] = particles[index];
                            particles[index] = temp;
                        }
                    }
                    else if(direction == "Right")
                    {
                        if(ValidateIndex(index, direction, particles))
                        {
                            string temp = particles[index + 1];
                            particles[index + 1] = particles[index];
                            particles[index] = temp;
                        }
                    }
                }
                else if(command == "Check")
                {
                    if(commandArgs[1] == "Even")
                    {
                        for (int i = 0; i < particles.Length; i++)
                        {
                            if(i % 2 == 0)
                            {
                                Console.Write(particles[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if(commandArgs[1] == "Odd")
                    {
                        for (int i = 0; i < particles.Length; i++)
                        {
                            if (i % 2 != 0)
                            {
                                Console.Write(particles[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"You crafted {string.Join("", particles)}!");
        }

        static bool ValidateIndex(int index, string direction, string[] particles)
        {
            if (index >= 0 && index < particles.Length)
            {
                if(direction == "Left")
                {
                    if(index - 1 >= 0 )
                    {
                        return true;
                    }
                }
                else if(direction == "Right")
                {
                    if(index + 1 < particles.Length)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
