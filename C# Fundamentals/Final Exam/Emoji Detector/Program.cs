namespace Emoji_Detector
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.Numerics;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> cool = new List<string>();

            string text = Console.ReadLine();

            BigInteger coolThreshold = 1;

            string digitPattern = @"(?<dig>\d)";

            MatchCollection digits = Regex.Matches(text, digitPattern);

            foreach (Match match1 in digits)
            {
                coolThreshold *= BigInteger.Parse(match1.Groups["dig"].Value);
            }

            string pattern = @"([:*]{2})([A-Z]{1}[a-z]{2,})\1";

            MatchCollection emojiMatches = Regex.Matches(text, pattern);

            long cnt = 0;

            foreach (Match match in emojiMatches)
            {
                string emoji = match.Groups[2].Value;

                if (emoji != null)
                {
                    cnt++;
                }

                string surr = match.Groups[1].Value;

                BigInteger sum = 0;

                for (int i = 0; i < emoji.Length; i++)
                {
                    if (char.IsLetter(emoji[i]))
                    {
                        sum += emoji[i];
                    }
                }

                if (sum > coolThreshold)
                {
                    cool.Add($"{surr}{emoji}{surr}");
                }
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");

            Console.WriteLine($"{cnt} emojis found in the text. The cool ones are:");

            foreach (var emoji in cool)
            {
                Console.WriteLine(emoji.TrimEnd());
            }
        }
    }
}
