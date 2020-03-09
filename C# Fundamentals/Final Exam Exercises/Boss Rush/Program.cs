namespace Boss_Rush
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Regex rgx = new Regex(@"([|])([A-Z]{4,})\1:([#])([A-Za-z]+ [A-Za-z]+)\3");

                var matches = rgx.Matches(input);

                string name = "";
                string title = "";

                foreach (Match match in matches)
                {
                    name = match.Groups[2].Value;
                    title = match.Groups[4].Value;
                }

                if (name != "")
                {
                    Console.WriteLine($"{name}, The {title}");
                    Console.WriteLine($">> Strength: {name.Length}");
                    Console.WriteLine($">> Armour: {title.Length}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}
