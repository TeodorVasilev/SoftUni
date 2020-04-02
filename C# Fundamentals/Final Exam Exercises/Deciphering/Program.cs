namespace Deciphering
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^[d-z{}|#]+";

            char[] encrypted = Console.ReadLine().ToCharArray();

            var match = Regex.Match(new string(encrypted), pattern);

            if (match.Length == encrypted.Length)
            {
                for (int i = 0; i < encrypted.Length; i++)
                {
                    int current = encrypted[i];

                    current -= 3;

                    encrypted[i] = (char)current;
                }
            }
            else
            {
                Console.WriteLine("This is not the book you are looking for.");

                return;
            }


            string text = new string(encrypted);

            string[] subs = Console.ReadLine().Split();

            while (text.Contains(subs[0]))
            {
                text = text.Replace(subs[0], subs[1]);
            }


            Console.WriteLine(text);
        }
    }
}
