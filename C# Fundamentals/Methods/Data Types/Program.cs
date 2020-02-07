namespace Data_Types
{
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			string inputType = Console.ReadLine();

			if(inputType == "int")
			{
				int a = int.Parse(Console.ReadLine());
				PrintInput(a);
			}
			else if(inputType == "real")
			{
				double a = double.Parse(Console.ReadLine());
				PrintInput(a);
			}
			else if(inputType =="string")
			{
				string a = Console.ReadLine();
				PrintInput(a);
			}
		}

		static void PrintInput(int a)
		{
			Console.WriteLine(a * 2);
		}

		static void PrintInput(double a)
		{
			Console.WriteLine($"{a * 1.5:f2}");
		}

		static void PrintInput(string a)
		{
			Console.WriteLine($"${a}$");
		}
	}
}
