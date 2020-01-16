namespace _05._Login
{
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			string username = Console.ReadLine();
			string password = Reverse(username);

			string input = Console.ReadLine();

			int count = 0;

			while (input != password)
			{
				if(input != password)
				{
					Console.WriteLine("Incorrect password. Try again.");
					count++;
				}

				if(count == 3)
				{
					Console.WriteLine($"User {username} blocked!");
					return;
				}

				input = Console.ReadLine();
			}

			Console.WriteLine($"User {username} logged in.");
		}

		static string Reverse(string username)
		{
			char[] arr = username.ToCharArray();
			Array.Reverse(arr);
			return new string(arr);
		}
	}
}
