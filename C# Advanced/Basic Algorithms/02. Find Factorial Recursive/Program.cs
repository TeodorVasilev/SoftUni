using System;

namespace _02._Find_Factorial_Recursive
{
	class Program
	{
		static void Main(string[] args)
		{
			var result = Factorial(4);
			Console.WriteLine(result);
		}

		public static int Factorial(int n)
		{
			if (n < 0)
			{
				throw new InvalidOperationException("Invalid operation!");
			}

			if (n == 0)
			{
				return 1;
			}
			
			return n * Factorial(n - 1);
		}
	}
}
