namespace Man_O_War
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] pirateSections = Console.ReadLine().Split('>').Select(int.Parse).ToArray();
            int[] warshipSections = Console.ReadLine().Split('>').Select(int.Parse).ToArray();
            int sectionMaxHealth = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "Retire")
            {
                string[] commandArgs = input.Split();

                string command = commandArgs[0];

                if(command == "Fire")
                {
                    int index = int.Parse(commandArgs[1]);
                    int damage = int.Parse(commandArgs[2]);

                    if(index >= 0 && index < warshipSections.Length)
                    {
                        warshipSections[index] -= damage;

                        if(warshipSections[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }
                }
                else if(command == "Defend")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);
                    int damage = int.Parse(commandArgs[3]);

                    if (startIndex >= 0 && startIndex < pirateSections.Length
                        && endIndex >=0 && endIndex < pirateSections.Length)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateSections[i] -= damage;

                            if(pirateSections[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }

                }
                else if(command == "Repair")
                {
                    int index = int.Parse(commandArgs[1]);
                    int health = int.Parse(commandArgs[2]);

                    if (index >= 0 && index < pirateSections.Length)
                    {
                        pirateSections[index] += health;

                        if(pirateSections[index] > sectionMaxHealth)
                        {
                            pirateSections[index] = sectionMaxHealth;
                        }
                    }
                }
                else if(command == "Status")
                {
                    double repairSectionsPoints = sectionMaxHealth * 0.20;

                    int repairCnt = 0;

                    for (int i = 0; i < pirateSections.Length; i++)
                    {
                        if(pirateSections[i] < repairSectionsPoints)
                        {
                            repairCnt++;
                        }
                    }

                    Console.WriteLine($"{repairCnt} sections need repair.");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Pirate ship status: {pirateSections.Sum()}");
            Console.WriteLine($"Warship status: {warshipSections.Sum()}");
        }
    }
}
