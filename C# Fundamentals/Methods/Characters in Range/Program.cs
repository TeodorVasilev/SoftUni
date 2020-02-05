using System;

namespace Characters_in_Range
{
	class Program
	{
		static void Main(string[] args)
		{
			char a = char.Parse(Console.ReadLine());
			char b = char.Parse(Console.ReadLine());

			PrintCharsInRange(a, b);
		}

		static void PrintCharsInRange(char a, char b)
		{
			if(a < b)
			{
				a++;

				for (char i = a; i < b; i++)
				{
					Console.Write(i + " ");
				}
			}
			else
			{
				b++;

				for (char i = b; i < a; i++)
				{
					Console.Write(i + " ");
				}
			}
		}
	}
}
