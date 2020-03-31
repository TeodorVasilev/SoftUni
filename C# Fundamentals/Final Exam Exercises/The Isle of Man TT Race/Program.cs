namespace The_Isle_of_Man_TT_Race
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([#|$|%|*|&])(?<name>\w+)\1=(?<length>\d+)!{2}(?<hashcode>.+)";

            while (true)
            {
                string input = Console.ReadLine();

                MatchCollection matches = Regex.Matches(input, pattern);

                string racer = "";
                int length = 0;
                string code = "";

                foreach (Match match in matches)
                {
                    racer = match.Groups["name"].Value;
                    length = int.Parse(match.Groups["length"].Value);
                    code = match.Groups["hashcode"].Value;
                }

                if(length == code.Length && racer != "" && length != 0 && code != "")
                {
                    char[] temp = code.ToCharArray();

                    for (int i = 0; i < temp.Length; i++)
                    {
                        char current = temp[i];

                        current += (char)length;

                        temp[i] = current;
                    }

                    Console.WriteLine($"Coordinates found! {racer} -> {new string(temp)}");

                    return;
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }
            }
        }
    }
}
