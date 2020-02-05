namespace Password_Validator
{
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			int digitsCount = PasswordDigitsValidator(input);
			bool isNumbersAndLettersOnly = PasswordSymbolsValidator(input);


			if (input.Length < 6 || input.Length > 10)
			{
				Console.WriteLine("Password must be between 6 and 10 characters");

				if (isNumbersAndLettersOnly == false)
				{
					Console.WriteLine("Password must consist only of letters and digits");
				}

				if (digitsCount < 2)
				{
					Console.WriteLine("Password must have at least 2 digits");
				}
			}
			else
			{
				if (isNumbersAndLettersOnly == false)
				{
					Console.WriteLine("Password must consist only of letters and digits");
				}

				if (digitsCount < 2)
				{
					Console.WriteLine("Password must have at least 2 digits");
				}
			}

			if(input.Length >= 6 && input.Length <= 10)
			{
				if(isNumbersAndLettersOnly)
				{
					if(digitsCount >= 2)
					{
						Console.WriteLine("Password is valid");
					}
				}
			}
		}

		static int PasswordDigitsValidator(string input)
		{
			int digitsCount = 0;

			for (int i = 0; i < input.Length; i++)
			{
				char symbol = input[i];

				if (char.IsDigit(symbol))
				{
					digitsCount++;
				}
			}

			return digitsCount;
		}

		static bool PasswordSymbolsValidator(string input)
		{
			for (int i = 0; i < input.Length; i++)
			{
				char symbol = input[i];

				if (!char.IsDigit(symbol) && !char.IsLetter(symbol))
				{
					return false;
				}
			}

			return true;
		}
	}
}
