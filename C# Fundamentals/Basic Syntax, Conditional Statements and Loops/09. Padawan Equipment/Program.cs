using System;

namespace _09._Padawan_Equipment
{
	class Program
	{
		static void Main(string[] args)
		{
			double money = double.Parse(Console.ReadLine());
			int studentCount = int.Parse(Console.ReadLine());
			double lightsaberPrice = double.Parse(Console.ReadLine());
			double robePrice = double.Parse(Console.ReadLine());
			double beltPrice = double.Parse(Console.ReadLine());

			double lightsaberCount = Math.Ceiling(studentCount + (studentCount * 0.10));
			double freeBelts = 0;

			for (int i = 1; i <= studentCount; i++)
			{
				if(i % 6 == 0)
				{
					freeBelts++;
				}
			}

			double totalPrice = (lightsaberCount * lightsaberPrice) + (studentCount * robePrice) + ((studentCount - freeBelts) * beltPrice);

			if(totalPrice <= money)
			{
				Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
			}
			else
			{
				Console.WriteLine($"Ivan Cho will need {totalPrice - money:f2}lv more.");
			}
		}
	}
}
