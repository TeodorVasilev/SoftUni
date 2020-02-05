namespace Top_Number
{
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			for (int i = 1; i <= n; i++)
			{
				int digitsSum = GetSumOfDigits(i);

				if(HoldOddDigit(i))
				{
					if(digitsSum % 8 == 0)
					{
						Console.WriteLine(i);
					}
				}
			}
		}

		static int GetSumOfDigits(int n)
		{
			int sum = 0;

			while (n != 0)
			{
				sum += n % 10;

				n /= 10;
			}

			return sum;
		}

		static bool HoldOddDigit(int n)
		{
			while (n != 0)
			{
				if((n % 10) % 2 != 0)
				{
					return true;
				}

				n /= 10;
			}

			return false;
		}
	}
}
