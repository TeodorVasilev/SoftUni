namespace Race
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> racers = Console.ReadLine().Split(", ").ToList();

            Dictionary<string, int> racersDistance = new Dictionary<string, int>();

            for (int i = 0; i < racers.Count; i++)
            {
                racersDistance.Add(racers[i], 0);
            }

            string input = Console.ReadLine();

            string namePattern = @"(?<name>[A-Za-z]+)";

            string distancePattern = @"(?<dist>\d+)";

            while (input != "end of race")
            {
                MatchCollection nameMatches = Regex.Matches(input, namePattern);

                string name = "";

                foreach (Match match in nameMatches)
                {
                    name += match.Groups["name"].Value;
                }

                MatchCollection sumMatches = Regex.Matches(input, distancePattern);

                string digits = "";

                foreach (Match match in sumMatches)
                {
                    digits += match.Groups["dist"].Value;
                }

                int sum = 0;

                for (int i = 0; i < digits.Length; i++)
                {
                    sum += int.Parse(digits[i].ToString());
                }

                if(racersDistance.ContainsKey(name))
                {
                    racersDistance[name] += sum;
                }

                input = Console.ReadLine();
            }

            var sorted = racersDistance.OrderByDescending(x => x.Value);

            Console.WriteLine($"1st place: {sorted.ElementAt(0).Key}");

            Console.WriteLine($"2nd place: {sorted.ElementAt(1).Key}");

            Console.WriteLine($"3rd place: {sorted.ElementAt(2).Key}");
        }
    }
}
