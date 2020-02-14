namespace Merging_Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int count = Math.Max(firstNumbers.Count, secondNumbers.Count);

            List<int> result = new List<int>();

            for (int i = 0; i < count; i++)
            {
                if (i < firstNumbers.Count)
                {
                    result.Add(firstNumbers[i]);
                }
                if (i < secondNumbers.Count)
                {
                    result.Add(secondNumbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
