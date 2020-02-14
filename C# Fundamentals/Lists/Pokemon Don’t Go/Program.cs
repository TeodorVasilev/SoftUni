namespace Pokemon_Don_t_Go
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int removedElementsSum = 0;

            while (numbers.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());

                int element = 0;

                if(index < 0)
                {
                    element = numbers[0];
                    int lastElement = numbers[numbers.Count - 1];
                    numbers.RemoveAt(0);
                    numbers.Insert(0, lastElement);
                    removedElementsSum += element;
                }
                else if(index > numbers.Count - 1)
                {
                    element = numbers[numbers.Count - 1];
                    int firtElement = numbers[0];
                    numbers.RemoveAt(numbers.Count - 1);
                    numbers.Add(firtElement);
                    removedElementsSum += element;
                }
                else
                {
                    element = numbers[index];
                    numbers.RemoveAt(index);
                    removedElementsSum += element;
                }

                for (int i = 0; i < numbers.Count; i++)
                {
                    if(numbers[i] > element)
                    {
                        numbers[i] -= element;
                    }
                    else
                    {
                        numbers[i] += element;
                    }
                }
            }

            Console.WriteLine(removedElementsSum);
        }
    }
}
