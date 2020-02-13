namespace Append_Arrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new string[] {"|", " | " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            
            input.Reverse();

            List<int> result = new List<int>();

            //for (int i = 0; i < input.Count; i++)
            //{
            //    int[] numbers = input[i].Split(' ').Select(int.Parse).ToArray();

            //    for (int k = 0; k < numbers.Length; k++)
            //    {
            //        result.Add(numbers[k]);
            //    }
            //}

            //List<string> result = new List<string>();

            //for (int i = 0; i < input.Count; i++)
            //{
            //    result.Add(input[i].TrimStart().TrimEnd().Trim());
            //}

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
