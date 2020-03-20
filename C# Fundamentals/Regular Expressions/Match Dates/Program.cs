namespace Match_Dates
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            string dates = Console.ReadLine();

            MatchCollection matches = Regex.Matches(dates, pattern);

            foreach (Match match in matches)
            {
                string day = match.Groups["day"].Value;
                string month = match.Groups["month"].Value;
                string years = match.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {years}");
            }
        }
    }
}
