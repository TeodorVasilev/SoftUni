namespace Message_Encrypter
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([@*])(?<tag>[A-Z][a-z]{2,})\1: \[(?<first>\w{1})]\|\[(?<sec>\w{1})]\|\[(?<third>\w{1})]\|$";

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                MatchCollection matches = Regex.Matches(input, pattern);

                string tag = "";
                string first = "";
                string sec = "";
                string third = "";

                foreach (Match match in matches)
                {
                    tag = match.Groups["tag"].Value;
                    first = match.Groups["first"].Value;
                    sec = match.Groups["sec"].Value;
                    third = match.Groups["third"].Value;
                }

                if(tag != "" && first != "" && sec != "" && third != "")
                {
                    char one = char.Parse(first);
                    char two = char.Parse(sec);
                    char three = char.Parse(third);

                    Console.WriteLine($"{tag}: {(int)one} {(int)two} {(int)three}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
