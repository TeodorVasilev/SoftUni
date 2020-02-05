namespace Calculations
{
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			string operation = Console.ReadLine();
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());

			if(operation == "subtract")
			{
				Subtract(a, b);
			}
			else if(operation == "add")
			{
				Add(a, b);
			}
			else if(operation == "multiply")
			{
				Multiply(a, b);
			}
			else if(operation == "divide")
			{
				Divide(a, b);
			}
		}

		static void Subtract(int a, int b)
		{
			Console.WriteLine(a - b);
		}

		static void Add(int a, int b)
		{
			Console.WriteLine(a + b);
		}

		static void Multiply(int a, int b)
		{
			Console.WriteLine(a * b);
		}

		static void Divide(int a, int b)
		{
			Console.WriteLine(a / b);
		}
	}
}
