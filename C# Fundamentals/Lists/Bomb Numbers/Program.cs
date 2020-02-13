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

                if (index - power < 0)
                {
                    numbers.RemoveRange(0, power * 2 + 1);
                }
                else if(power * 2 + 1 > numbers.Count - 1)
                {
                    numbers.RemoveRange(index - power, numbers.Count - 2);
                }
                else
                {
                    numbers.RemoveRange(index - power, power * 2 + 1);
                }
            }

            Console.WriteLine(numbers.Sum());

            //1 1 2 1 1 1 2 1 1 1 2 1 1 2
            //2 1
        }
    }
}
