namespace Word_Synonyms
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> wordSynonyms = new Dictionary<string, List<string>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if(!wordSynonyms.ContainsKey(word))
                {
                    wordSynonyms[word] = new List<string>();
                    wordSynonyms[word].Add(synonym);
                }
                else
                {
                    wordSynonyms[word].Add(synonym);
                }
            }

            foreach (var kvp in wordSynonyms)
            {
                Console.WriteLine($"{kvp.Key} - {string.Join(", ", kvp.Value)}");
            }
        }
    }
}
