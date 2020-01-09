namespace _01._Library
{
	using System.Collections;
	using System.Collections.Generic;

	public class Library : IEnumerable<Book>
	{
		private SortedSet<Book> books;

		public Library()
		{
			this.books = new SortedSet<Book>(new BookComparator());
		}

		public void Add(Book book)
		{
			this.books.Add(book);
		}

		public IEnumerator<Book> GetEnumerator()
		{
			foreach (var book in this.books)
			{
				yield return book;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
			=> this.GetEnumerator();
	}
}
