namespace Palindrome_Integers
{
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			while (input != "END")
			{
				string reversed = ReverseString(input);

				if(reversed.Equals(input))
				{
					Console.WriteLine("true");
				}
				else
				{
					Console.WriteLine("false");
				}

				input = Console.ReadLine();
			}
		}

		public static string ReverseString(string input)
		{
			char[] arr = input.ToCharArray();
			Array.Reverse(arr);
			return new string(arr);
		}
	}
}
