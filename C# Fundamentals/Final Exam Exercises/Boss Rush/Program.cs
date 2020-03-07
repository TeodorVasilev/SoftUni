namespace Boss_Rush
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Regex rgx = new Regex("[|][A-Z]{4,}[|]:[#][A-Z][a-z]+ [a-z]+#");

                bool isMatch = rgx.IsMatch(input);

                if(isMatch)
                {
                    string[] bossArgs = input.Split('|', ':', '#');
                    bossArgs = bossArgs.Where(x => x != "").ToArray();

                    string name = bossArgs[0];
                    string title = bossArgs[1];

                    Console.WriteLine($"{name}, The {title}");
                    Console.WriteLine($"Strength: {name.Length}");
                    Console.WriteLine($"Armour: {title.Length}");
                }
            }
        }
    }
}
