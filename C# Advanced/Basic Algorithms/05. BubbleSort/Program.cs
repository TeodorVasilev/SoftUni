using System;

namespace _05._BubbleSort
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = { 1, 3, 4, 2, 5, 6 };

			for (int i = 0; i < numbers.Length; i++)
			{
				for (int j = i + 1; j < numbers.Length - 1; j++)
				{
					if(numbers[i] > numbers[j])
					{
						int temp = numbers[i];
						numbers[i] = numbers[j];
						numbers[j] = temp;
					}
				}
			}
		}
	}
}
