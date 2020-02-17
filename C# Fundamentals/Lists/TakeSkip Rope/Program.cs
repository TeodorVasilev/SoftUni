namespace TakeSkip_Rope
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            char[] textSplit = text.ToCharArray();

            List<int> numbers = new List<int>();
            List<char> letters = new List<char>();

            for (int i = 0; i < textSplit.Length; i++)
            {
                char symbol = textSplit[i];

                if(char.IsDigit(symbol))
                {
                    int number = int.Parse(new string(symbol, 1));
                    numbers.Add(number);
                }

                if (char.IsLetter(symbol) || char.IsPunctuation(symbol))
                {
                    letters.Add(symbol);
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if(i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }

            char[] lettersToCharArr = letters.ToArray();

            string lettersToString = new string(lettersToCharArr);

            //string result = string.Empty;
        }
    }
}
