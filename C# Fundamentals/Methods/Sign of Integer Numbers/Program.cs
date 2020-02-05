namespace Sign_of_Integer_Numbers
{
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			PrintIntegerSign(n);
		}

		static void PrintIntegerSign(int n)
		{
			if(n < 0)
			{
				Console.WriteLine($"The number {n} is negative.");
			}
			else if(n > 0)
			{
				Console.WriteLine($"The number {n} is positive.");
			}
			else
			{
				Console.WriteLine($"The number {n} is zero.");
			}
		}
	}
}
