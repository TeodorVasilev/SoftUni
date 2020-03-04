namespace Odd_Occurrences
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<string, int> wordsCnt = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToLower();

                if (!wordsCnt.ContainsKey(words[i]))
                {
                    wordsCnt[words[i]] = 1;
                }
                else
                {
                    wordsCnt[words[i]]++;
                }
            }

            foreach (var kvp in wordsCnt)
            {
                if(kvp.Value % 2 != 0)
                {
                    Console.Write(kvp.Key + " ");
                }
            }
        }
    }
}
