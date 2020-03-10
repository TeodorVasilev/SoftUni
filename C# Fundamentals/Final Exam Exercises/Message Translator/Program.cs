namespace Message_Translator
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Regex rgx = new Regex(@"(!)([A-Z][a-z]{3,})\1:\[([A-Za-z]{8,})\]");

            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();

                var matches = rgx.Matches(message);

                string type = "";
                string msg = "";

                foreach (Match match in matches)
                {
                    type = match.Groups[2].Value;
                    msg = match.Groups[3].Value;
                }

                if (type == "")
                {
                    Console.WriteLine("The message is invalid");
                }
                else
                {
                    int[] letValues = new int[msg.Length];

                    for (int k = 0; k < msg.Length; k++)
                    {
                        char current = msg[k];

                        letValues[k] = current;
                    }

                    Console.WriteLine($"{type}: {string.Join(" ", letValues)}");
                }
            }
        }
    }
}
