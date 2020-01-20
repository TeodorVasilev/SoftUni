namespace BorderControl
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class StartUp
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			List<IBuyer> buyers = new List<IBuyer>();

			for (int i = 0; i < n; i++)
			{
				string[] splited = Console.ReadLine().Split(' ');

				if (splited.Length == 4)
				{
					string name = splited[0];
					int age = int.Parse(splited[1]);
					string id = splited[2];
					string birthdate = splited[3];

					Citizen citizen = new Citizen(name, age, id, birthdate);

					buyers.Add(citizen);
				}
				else if (splited.Length == 3)
				{
					string name = splited[0];
					int age = int.Parse(splited[1]);
					string group = splited[2];

					Rebel rebel = new Rebel(name, age, group);

					buyers.Add(rebel);
				}
			}

			string input = Console.ReadLine();
			
			while (input != "End")
			{
				IBuyer buyer = null;

				try
				{
					buyer = buyers.FirstOrDefault(b => b.Name == input);

					buyer.BuyFood();
				}
				catch (Exception)
				{
					input = Console.ReadLine();
					continue;
				}
				
				input = Console.ReadLine();
			}

			int food = 0;

			foreach (var buyer in buyers)
			{
				food += buyer.Food;
			}

			Console.WriteLine(food);
		}
	}
}
