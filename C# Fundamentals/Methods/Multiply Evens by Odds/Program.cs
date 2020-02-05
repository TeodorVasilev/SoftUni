namespace Multiply_Evens_by_Odds
{
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			string number = Console.ReadLine();
			int n = int.Parse(number);

			int evenSum = GetEvenDigitsSum(n, number);
			int oddSum = GetOddDigitsSum(n, number);

			Console.WriteLine(GetMultipleOfEvensAndOdds(evenSum, oddSum));
		}

		static int GetMultipleOfEvensAndOdds(int evenSum, int oddSum)
		{
			return evenSum * oddSum;
		}

		static int GetEvenDigitsSum(int n, string number)
		{
			int sum = 0;

			for (int i = 0; i < number.Length; i++)
			{
				int digit = Math.Abs(n % 10);
				n /= 10;
				
				if(digit % 2 == 0)
				{
					sum += digit;
				}
			}

			return sum;
		}

		static int GetOddDigitsSum(int n, string number)
		{
			int sum = 0;

			for (int i = 0; i < number.Length; i++)
			{
				int digit = Math.Abs(n % 10);
				n /= 10;

				if (digit % 2 != 0)
				{
					sum += digit;
				}
			}

			return sum;
		}
	}
}
