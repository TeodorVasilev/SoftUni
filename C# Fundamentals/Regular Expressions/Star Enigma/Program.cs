namespace Star_Enigma
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@(?<planet>[A-Z][a-z]+)[^@\-!:>]*\:(?<population>\d+)[^@\-!:>]*!(?<attack>[AD])![^@\-!:>]*->(?<soldiers>\d+)";

            List<string> attackedPlanets = new List<string>();

            List<string> destroyedPlanets = new List<string>();
            
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string encryptedMessage = Console.ReadLine();

                int specialNumber = SpecialLetCount(encryptedMessage);

                string decrypted = DecryptMessage(encryptedMessage, specialNumber);

                Match match = Regex.Match(decrypted, pattern);

                if(match.Success)
                {
                    string planetName = match.Groups["planet"].Value;

                    string attackType = match.Groups["attack"].Value;

                    if(attackType == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else if(attackType == "D")
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }

            PrintOutput(attackedPlanets, "Attacked");
            PrintOutput(destroyedPlanets, "Destroyed");
        }

        public static void PrintOutput(List<string> planets, string attackType)
        {
            Console.WriteLine($"{attackType} planets: {planets.Count}");

            foreach (string planet in planets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }

        public static string DecryptMessage(string message, int number)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < message.Length; i++)
            {
                char current = message[i];

                char decrypted = (char)(current - number);

                sb.Append(decrypted);
            }

            return sb.ToString();
        }

        public static int SpecialLetCount(string message)
        {
            int count = 0;

            char[] specialLetter = { 's', 't', 'a', 'r' };

            for (int i = 0; i < message.Length; i++)
            {
                char current = message[i];

                if(specialLetter.Contains(char.ToLower(current)))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
