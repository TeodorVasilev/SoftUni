namespace _04._Shopping_Spree
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class Program
	{
		public static void Main(string[] args)
		{
			string[] peopleArgs = Console.ReadLine().Split(new char[] {'=', ';' }, StringSplitOptions.RemoveEmptyEntries);

			try
			{
				List<Person> persons = new List<Person>();

				for (int i = 0; i < peopleArgs.Length; i += 2)
				{
					string name = peopleArgs[i];
					decimal money = decimal.Parse(peopleArgs[i + 1]);

					Person person = new Person(name, money);

					persons.Add(person);
				}

				string[] productArgs = Console.ReadLine().Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);

				List<Product> products = new List<Product>();

				for (int i = 0; i < productArgs.Length; i += 2)
				{
					string name = productArgs[i];
					decimal price = decimal.Parse(productArgs[i + 1]);

					Product product = new Product(name, price);

					products.Add(product);
				}

				string input = Console.ReadLine();

				while (input != "END")
				{
					string[] personProduct = input.Split();

					string personName = personProduct[0];
					string productName = personProduct[1];

					Product product = products.Where(p => p.Name == productName).FirstOrDefault();

					Person person = persons.Where(p => p.Name == personName).FirstOrDefault();

					person.AddProduct(product);

					input = Console.ReadLine();
				}

				foreach (var person in persons)
				{
					Console.WriteLine(person);
				}
			}
			catch (ArgumentException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
