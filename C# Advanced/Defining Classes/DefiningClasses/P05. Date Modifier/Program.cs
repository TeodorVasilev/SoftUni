using System;

namespace P05._Date_Modifier
{
	class Program
	{
		static void Main(string[] args)
		{
			string firstDate = Console.ReadLine();
			string secondDate = Console.ReadLine();

			DateModifier dateModifier = new DateModifier();

			var daysDiff = dateModifier.CalculateDayDiffrence(firstDate, secondDate);

			Console.WriteLine(daysDiff);
		}
	}
}
