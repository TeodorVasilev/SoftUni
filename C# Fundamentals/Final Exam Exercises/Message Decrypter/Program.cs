namespace Message_Decrypter
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^([$|%])(?<tag>[A-Z][a-z]{2,})\1: \[(?<first>\d+)]\|\[(?<sec>\d+)]\|\[(?<third>\d+)]\|$";

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                MatchCollection matches = Regex.Matches(input, pattern);

                string tag = "";
                int one = 0;
                int two = 0;
                int three = 0;

                foreach (Match match in matches)
                {
                    tag = match.Groups["tag"].Value;
                    one = int.Parse(match.Groups["first"].Value);
                    two = int.Parse(match.Groups["sec"].Value);
                    three = int.Parse(match.Groups["third"].Value);
                }

                if(tag != "")
                {
                    Console.WriteLine($"{tag}: {(char)one}{(char)two}{(char)three}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
