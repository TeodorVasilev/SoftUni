namespace Replace_Repeating_Chars
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = Console.ReadLine().ToCharArray();

            List<char> result = new List<char>();

            char current;

            for (int i = 0; i < chars.Length - 1; i++)
            {
                current = chars[i];

                if (current == chars[i + 1])
                {

                }
                else
                {
                    result.Add(chars[i]);
                }
            }

            char last = chars[chars.Length - 1];

            result.Add(last);

            Console.WriteLine(string.Join("", result));
        }
    }
}
