namespace Randomize_Words
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int randomIndex = rnd.Next(0, words.Length);

                string randomElement = words[randomIndex];
                string element = words[i];

                words[randomIndex] = element;
                words[i] = randomElement;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
