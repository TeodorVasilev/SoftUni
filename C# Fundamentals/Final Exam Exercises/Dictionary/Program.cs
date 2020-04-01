namespace Dictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> wordsDef = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            string[] splitted = input.Split(" | ");

            for (int i = 0; i < splitted.Length; i++)
            {
                string[] splt = splitted[i].Split(": ");

                string word = splt[0];
                string def = splt[1];

                if (!wordsDef.ContainsKey(word))
                {
                    wordsDef[word] = new List<string>();
                    wordsDef[word].Add(def);
                }
                else
                {
                    wordsDef[word].Add(def);
                }
            }

            string[] words = Console.ReadLine().Split(" | ");

            for (int i = 0; i < words.Length; i++)
            {
                if (wordsDef.ContainsKey(words[i]))
                {
                    Console.WriteLine(words[i]);

                    foreach (var def in wordsDef[words[i]].OrderByDescending(x => x.Length))
                    {
                        Console.WriteLine($" -{def}");
                    }
                }
            }

            string command = Console.ReadLine();

            if (command == "End")
            {
                return;
            }
            else if (command == "List")
            {
                var sorted = wordsDef.OrderBy(x => x.Key);

                foreach (var word in sorted)
                {
                    Console.Write(word.Key + " ");
                }
            }
        }
    }
}
