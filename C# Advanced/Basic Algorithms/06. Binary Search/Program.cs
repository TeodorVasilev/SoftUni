using System;

namespace _06._Binary_Search
{
	class Program
	{
		static void Main(string[] args)
		{
			var numbers = new int[] { 1, 5, 10, 15, 18, 20, 22, 160, 254, 380, 500, 870 };

			Console.WriteLine(BinarySearch(numbers, 70, 0, numbers.Length -1));
		}

		public static int BinarySearch(int[] numbers, int key, int start, int end)
		{
			while (start <= end)
			{
				var mid = (start + end) / 2;

				if (numbers[mid] > key)
				{
					end = mid - 1;
				}
				else if (numbers[mid] < key)
				{
					start = mid + 1;
				}
				else
				{
					return mid;
				}
			}

			return -1;
		}
	}
}
