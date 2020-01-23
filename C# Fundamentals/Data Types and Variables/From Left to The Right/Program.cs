namespace From_Left_to_The_Right
{
	using System;
    using System.Linq;

    public class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				long sum = 0;

				long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();

				if(numbers[0] > numbers[1])
				{
					while (numbers[0] != 0)
					{
						sum += numbers[0] % 10;
						numbers[0] /= 10;
					}
				}
				else
				{
					while (numbers[1] != 0)
					{
						sum += numbers[1] % 10;
						numbers[1] /= 10;
					}
				}

				Console.WriteLine(Math.Abs(sum));
			}
		}
	}
}
