namespace WebCrawler
{
	using System;
	using System.Threading.Tasks;
	public class Program
	{
		private static Crawler crawler = new Crawler();

		static void Main(string[] args)
		{
			string url = Console.ReadLine();

			while (url != string.Empty)
			{
				//crawler.Crawl(url);
				CrawlAsync(url);
				url = Console.ReadLine();
			}
		}

		static async void CrawlAsync(string url)
		{
			await Task.Run(() => crawler.Crawl(url));
			Console.WriteLine("Where do you want to crawl?");
		}
	}
}