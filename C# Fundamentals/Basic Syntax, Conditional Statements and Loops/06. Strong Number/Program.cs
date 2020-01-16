namespace _06._Strong_Number
{
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			string number = Console.ReadLine();
			int total = 0;

			foreach (char ch in number)
			{
				int num = ch - 48;
				int factoriel = 1;

				for (var j = 1; j <= num; j++)
				{
					factoriel *= j;
				}

				total += factoriel;
			}

			int stringToNum = int.Parse(number);

			if (stringToNum == total)
			{
				Console.WriteLine("yes");
			}


			else if (stringToNum != total)
			{
				Console.WriteLine("no");
			}
		}
	}
}
