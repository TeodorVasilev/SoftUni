namespace String_Explosion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split('>');

            int power = 0;
            int reminder = 0;

            for (int i = 1; i < text.Length; i++)
            {
                power = int.Parse("" + text[i][0]) + reminder;
                reminder = power - text[i].Length;

                if (power > text[i].Length)
                {
                    power = text[i].Length;
                }

                text[i] = text[i].Substring(power);

                if(reminder < 0)
                {
                    reminder = 0;
                }
            }

            string result = string.Join(">", text);
            Console.WriteLine(result);

        }
    }
}
