namespace _03.Animal_Farm
{
	using System;

	public class Program
	{
		public static void Main(string[] args)
		{
			string name = Console.ReadLine();
			int age = int.Parse(Console.ReadLine());

			Chicken chicken = new Chicken(name, age);

			Console.WriteLine(chicken);
		}
	}
}
