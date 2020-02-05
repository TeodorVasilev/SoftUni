namespace Vowels_Count
{
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			Console.WriteLine(GetVowelsCount(input));
		}

		static int GetVowelsCount(string input)
		{
			int count = 0;

			for (int i = 0; i < input.Length; i++)
			{
				char letter = input[i];

				switch(letter)
				{
					case 'a':
						count++;
						break;
					case 'e':
						count++;
						break;
					case 'i':
						count++;
						break;
					case 'o':
						count++;
						break;
					case 'u':
						count++;
						break;
					case 'A':
						count++;
						break;
					case 'E':
						count++;
						break;
					case 'I':
						count++;
						break;
					case 'O':
						count++;
						break;
					case 'U':
						count++;
						break;
				}
			}

			return count;
		}
	}
}
