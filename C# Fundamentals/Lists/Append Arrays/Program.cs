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

            List<int> numbers = new List<int>();

            foreach (var item in input)
            {
                numbers.AddRange(item.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
