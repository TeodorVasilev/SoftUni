namespace Balanced_Brackets
{
	using System;

	public class Program
	{
		//receive “(”, “)” or another string
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int opening = 0;
			int closing = 0;

			for (int i = 0; i < n; i++)
			{
				string input = Console.ReadLine();

				if(input == "(")
				{
					opening++;
				}
				else if(input == ")")
				{
					closing++;

					if(opening - closing != 0)
					{
						Console.WriteLine("UNBALANCED");
						return;
					}
				}
			}

			if(opening == closing)
			{
				Console.WriteLine("BALANCED");
			}
			else
			{
				Console.WriteLine("UNBALANCED");
			}
		}
	}
}
