namespace Recursive_Fibonacci
{
	using System;

	public class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			Console.Write(Fibonacci(n - 1) + " ");
		}
		public static int Fibonacci(int n)
		{
			if (n <= 1)
			{
				return 1;
			}
			else
			{
				return Fibonacci(n - 2) + Fibonacci(n - 1);
			}
		}
	}
}
