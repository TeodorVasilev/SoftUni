namespace Elevator
{
	using System;

	public class Program
	{
		static void Main(string[] args)
		{
			int numberOfPeople = int.Parse(Console.ReadLine());
			int elevatorCapacity = int.Parse(Console.ReadLine());

			int courses = (int)Math.Ceiling((double)numberOfPeople / elevatorCapacity);

			Console.WriteLine(courses);

		}
	}
}
