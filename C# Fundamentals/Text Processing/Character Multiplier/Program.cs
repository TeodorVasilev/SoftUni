namespace Character_Multiplier
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            string text1 = input[0];
            string text2 = input[1];

            Console.WriteLine(CharSum(text1, text2));
        }

        public static int CharSum(string text1, string text2)
        {
            int sum = 0;

            char[] temp1 = text1.ToCharArray();
            char[] temp2 = text2.ToCharArray();

            if(temp1.Length > temp2.Length)
            {
                for (int i = 0; i < temp1.Length; i++)
                {
                    if (i >= temp2.Length)
                    {
                        sum += temp1[i];
                    }
                    else
                    {
                        sum += temp2[i] * temp1[i];
                    }
                }
            }
            else if(temp2.Length > temp1.Length)
            {
                for (int i = 0; i < temp2.Length; i++)
                {
                    if(i >= temp1.Length)
                    {
                        sum += temp2[i];
                    }
                    else
                    {
                        sum += temp2[i] * temp1[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < temp1.Length; i++)
                {
                    sum += temp1[i] * temp2[i];
                }
            }

            return sum;
        }
    }
}
