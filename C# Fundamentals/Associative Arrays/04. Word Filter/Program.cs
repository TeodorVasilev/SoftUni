namespace _04.Word_Filter
{
	using System;
	using System.Linq;

	class Program
	{
		static void Main(string[] args)
		{
			string[] words = Console.ReadLine().Split().Where(w => w.Length % 2 == 0).ToArray();

			foreach (var word in words)
			{
				Console.WriteLine(word);
			}
		}
	}
}
