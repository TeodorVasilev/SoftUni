namespace Math_operations
{
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			string operation = Console.ReadLine();
			int b = int.Parse(Console.ReadLine());

			if (operation == "-")
			{
				Subtract(a, b);
			}
			else if (operation == "+")
			{
				Add(a, b);
			}
			else if (operation == "*")
			{
				Multiply(a, b);
			}
			else if (operation == "/")
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
