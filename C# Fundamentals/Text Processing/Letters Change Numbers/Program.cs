namespace Letters_Change_Numbers
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            for (int i = 0; i < words.Length; i++)
            {
                double tempSum = 0;
                string currentWord = words[i];
                char firstLetter = currentWord[0];
                char lastLetter = currentWord[currentWord.Length - 1]; ///
                double number = ParseNumber(currentWord);
                tempSum += number;

                int firstLetterPos = GetAlphabeticalPosition(firstLetter);
                int lastLetterPos = GetAlphabeticalPosition(lastLetter);

                if(char.IsUpper(firstLetter) && firstLetterPos > 0)
                {
                    tempSum /= firstLetterPos;
                }
                else if(char.IsLower(firstLetter) && firstLetterPos > 0)
                {
                    tempSum = number * firstLetterPos;
                }

                if (char.IsUpper(lastLetter) && lastLetterPos > 0)
                {
                    tempSum -= lastLetterPos;
                }
                else if(char.IsLower(lastLetter) && lastLetterPos > 0)
                {
                    tempSum += lastLetterPos;
                }

                sum += tempSum;
            }

            Console.WriteLine($"{sum:f2}");
        }

        private static int GetAlphabeticalPosition(char letter)
        {
            int positon = -1;

            if(char.IsLetter(letter))
            {
                if (char.IsUpper(letter))
                {
                    positon = letter - 64;
                }
                else
                {
                    positon = letter - 96;
                }
            }

            return positon;
        }

        public static double ParseNumber(string currentWord)
        {
            char[] numberAsChar = currentWord.Skip(1).Take(currentWord.Length - 2).ToArray();
            string numberAsString = string.Join("", numberAsChar);
            double number = double.Parse(numberAsString);

            return number;
        }
    }
}
