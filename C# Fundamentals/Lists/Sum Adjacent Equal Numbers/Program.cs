namespace Sum_Adjacent_Equal_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int k = 0; k < numbers.Count - 1; k++)
                {
                    if (numbers[k] == numbers[k + 1])
                    {
                        numbers[k] += numbers[k + 1];

                        numbers.Remove(numbers[k + 1]);
                    }
                }
            }
            
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
