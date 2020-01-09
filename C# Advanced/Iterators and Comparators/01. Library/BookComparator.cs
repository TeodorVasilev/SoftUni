namespace _01._Library
{
	using System.Collections.Generic;

	public class BookComparator : IComparer<Book>
	{
		public int Compare(Book first, Book second)
		{
			var titleCompare = first.Title.CompareTo(second.Title);

			if(titleCompare == 0)
			{
				titleCompare = first.Year - second.Year;
			}

			return titleCompare;
		}
	}
}
