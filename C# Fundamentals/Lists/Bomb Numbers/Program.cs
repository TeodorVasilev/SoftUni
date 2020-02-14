namespace Bomb_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] numberPower = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int number = numberPower[0];
            int power = numberPower[1];

            while (numbers.Contains(number))
            {
                int index = numbers.IndexOf(number);

                int removeIndex = Math.Max(0, index - power);
                int removeCount = Math.Min(numbers.Count - 1, index + power);

                for (int i = removeCount; i >= removeIndex; i--)
                {
                    numbers.RemoveAt(i);
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
