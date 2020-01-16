namespace _03._Vacantion
{
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			int peopleCount = int.Parse(Console.ReadLine());
			string groupType = Console.ReadLine();
			string day = Console.ReadLine();
			
			decimal price = 0;

			switch(groupType)
			{
				case "Students":
					switch(day)
					{
						case "Friday":
							price = 8.45m;
							break;
						case "Saturday":
							price = 9.80m;
							break;
						case "Sunday":
							price = 10.46m;
							break;
					}
					break;
				case "Business":
					switch (day)
					{
						case "Friday":
							price = 10.90m;
							break;
						case "Saturday":
							price = 15.60m;
							break;
						case "Sunday":
							price = 16.00m;
							break;
					}
					break;
				case "Regular":
					switch (day)
					{
						case "Friday":
							price = 15.00m;
							break;
						case "Saturday":
							price = 20.00m;
							break;
						case "Sunday":
							price = 22.50m;
							break;
					}
					break;
			}

			decimal totalPrice = 0;
			decimal discount = 0;

			if (groupType == "Students" && peopleCount >= 30)
			{
				totalPrice = peopleCount * price;
				discount = totalPrice * 0.15m;
			}
			else if (groupType == "Students")
			{
				totalPrice = peopleCount * price;
			}
			else if (groupType == "Business" && peopleCount >= 100)
			{
				peopleCount -= 10;
				totalPrice = peopleCount * price;
			}
			else if (groupType == "Business")
			{
				totalPrice = peopleCount * price;
			}
			else if (groupType == "Regular" && peopleCount >= 10 && peopleCount <= 20)
			{
				totalPrice = peopleCount * price;
				discount = totalPrice * 0.05m;
			}
			else if (groupType == "Regular")
			{
				totalPrice = peopleCount * price;
			}

			totalPrice -= discount;

			Console.WriteLine($"Total price: {totalPrice:f2}");
		}
	}
}
