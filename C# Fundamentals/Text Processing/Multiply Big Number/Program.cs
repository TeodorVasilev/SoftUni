namespace Multiply_Big_Number
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            char[] firstNum = Console.ReadLine().ToCharArray();

            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            StringBuilder sb = new StringBuilder();

            int reminder = 0;

            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                char current = firstNum[i];
                int currentNum = int.Parse(current.ToString());

                int sum = (currentNum * multiplier) + reminder;

                sb.Append(sum % 10);

                reminder = sum / 10;
            }

            if (reminder != 0)
            {
                sb.Append(reminder);
            }

            List<char> result = sb.ToString().Reverse().ToList();

            RemoveTrailingZero(result);

            Console.WriteLine(string.Join("", result));
        }

        public static void RemoveTrailingZero(List<char> result)
        {
            if (result[0] == '0')
            {
                int zeroCnt = 0;

                for (int j = 1; j < result.Count; j++)
                {
                    if (result[j] != '0')
                    {
                        zeroCnt = j;
                    }
                }

                for (int i = 0; i < zeroCnt; i++)
                {
                    result.RemoveAt(0);
                }
            }

        }
    }
}
