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
            List<int> numbers = new List<int>();
            List<string> letters = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                if(char.IsDigit(text[i]))
                {
                    int number = int.Parse(text[i].ToString());
                    numbers.Add(number);
                }
                else
                {
                    letters.Add(text[i].ToString());
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

            StringBuilder sb = new StringBuilder();

            int indexForSkip = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                List<string> temp = new List<string>(letters);

                temp = temp.Skip(indexForSkip).Take(takeList[i]).ToList();

                sb.Append(string.Join("", temp));

                indexForSkip += takeList[i] + skipList[i];
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
