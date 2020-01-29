namespace Max_Sequence_of_Equal_Elements
{
	using System;
    using System.Linq;

    public class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

			int maxSequence = 0;
			int maxElement = 0;

			for (int i = 0; i < numbers.Length; i++)
			{
				int element = numbers[i];
				int sequence = 0;

				for (int k = i; k < numbers.Length - 1; k++)
				{
					if(element == numbers[k + 1])
					{
						sequence++;
					}
					else
					{
						break;
					}
				}

				if(sequence > maxSequence)
				{
					maxSequence = sequence;
					maxElement = element;
				}
			}

			for (int i = 0; i <= maxSequence; i++)
			{
				Console.Write(maxElement + " ");
			}
		}
	}
}
