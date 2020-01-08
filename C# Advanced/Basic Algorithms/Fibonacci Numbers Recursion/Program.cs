using System;

namespace Fibonacci_Numbers_Recursion
{
	class Program
	{
		static void Main(string[] args)
		{
			FibonacciRecursive(9);
		}

		public static void FibonacciRecursive(long len)
		{
			FibonacciRecTemp(0, 1, 1, len);
		}
		private static void FibonacciRecTemp(long a, long b, long counter, long len)
		{
			if (counter <= len)
			{
				Console.Write($"{a} ");
				FibonacciRecTemp(b, a + b, counter + 1, len);
			}
		}
	}
}
