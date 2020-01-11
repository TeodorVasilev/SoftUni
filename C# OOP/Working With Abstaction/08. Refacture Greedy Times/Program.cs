namespace _08._Refacture_Greedy_Times
{
	using System;

	public class Program
	{
		static void Main(string[] args)
		{
			long bagCapacity = long.Parse(Console.ReadLine());

			string[] itemQuantity = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

			Bag bag = new Bag(bagCapacity);

			for (int i = 0; i < itemQuantity.Length; i+=2)
			{
				string item = itemQuantity[i];
				int quantity = int.Parse(itemQuantity[i + 1]);

				bag.Add(item, quantity);
			}

			Console.WriteLine(bag);
		}
	}
}
