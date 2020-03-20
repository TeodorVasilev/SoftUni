using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string rgx = @"[+]{1}[3][5][9]([ -])[2]\1\b[0-9]{3}\b\1\b[0-9]{4}\b";

            string phones = Console.ReadLine();

            var matches = Regex.Matches(phones, rgx);

            var matched = matches.Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", matched));
        }
    }
}
