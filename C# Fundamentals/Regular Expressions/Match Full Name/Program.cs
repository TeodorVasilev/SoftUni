namespace Match_Full_Name
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string rgx = (@"\b[A-Z]{1}[a-z]+\b[ ]{1}\b[A-Z]{1}[a-z]+\b");

            string names = Console.ReadLine();

            MatchCollection matches = Regex.Matches(names, rgx);

            foreach (Match match in matches)
            {
                Console.Write(match + " ");
            }

            Console.WriteLine();
        }
    }
}
