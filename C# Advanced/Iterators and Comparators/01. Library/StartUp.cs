namespace _01._Library
{
	using System;
	using System.Collections.Generic;

	public class StartUp
	{
		public static void Main(string[] args)
		{
			var library = new Library();

			library.Add(new Book("Amazon", 2015, "Ivan"));
			library.Add(new Book("Pesho", 2016, "Pesho"));
			library.Add(new Book("Pesho 2", 2003, "Pesho"));
			library.Add(new Book("Pesho 3", 2005, "Pesho"));
			library.Add(new Book("Pesho", 2007, "Pesho"));

			foreach (var book in library)
			{
				Console.WriteLine(book);
			}
		}
	}
}
