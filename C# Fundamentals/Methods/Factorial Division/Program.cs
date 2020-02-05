namespace Factorial_Division
{
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			double a = double.Parse(Console.ReadLine());
			double b = double.Parse(Console.ReadLine());

			double aFact = CalculateFactorial(a);
			double bFact = CalculateFactorial(b);

			Console.WriteLine($"{aFact / bFact:f2}");
		}

		static double CalculateFactorial(double a)
		{
			double fact = a;

			for (double i = fact - 1; i >= 1; i--)
			{
				fact *= i;
			}

			return fact;
		}
	}
}
