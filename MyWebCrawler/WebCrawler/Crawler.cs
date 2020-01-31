namespace WebCrawler
{
	using System;
	using System.Collections.Generic;
	using System.Net;
	using System.Threading.Tasks;

	public class Crawler
	{
		private HTMLParser parser;
		private const int MaxDepth = 3;
		private int depthCounter;
		private int linkCounter;

		public Crawler()
		{
			this.parser = new HTMLParser();
			depthCounter = 0;
			linkCounter = 0;
		}

		public void Crawl(string url)
		{
			string html;
			using (var client = new WebClient())
			{
				try
				{
					html = client.DownloadString(url);
				}
				catch (Exception wex)
				{
					return;
				}

				List<string> imgUrls = parser.GetImgSrcs(html);

				url = url.TrimEnd('/');

				for (int i = 0; i < imgUrls.Count; i++)
				{
					if (!imgUrls[i].StartsWith("http"))
					{
						imgUrls[i] = url + imgUrls[i];
					}
				}
				// Downloading Images
				#region
				foreach (var imgUrl in imgUrls)
				{
					int lastIndexForwardSlash = imgUrl.LastIndexOf('/');
					string fileName = imgUrl.Substring(lastIndexForwardSlash + 1);
					fileName = "images/" + fileName;
					try
					{
						client.DownloadFile(imgUrl, fileName);
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine(imgUrl);
						Console.ForegroundColor = ConsoleColor.White;
					}
					catch (Exception wex)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine(wex.Message);
					}
				}
				#endregion

				depthCounter++;
				//DFS for inner anchor urls
				if (depthCounter < MaxDepth)
				{
					List<string> anchorUrls = parser.GetAnchorUrls(html);

					for (int i = 0; i < anchorUrls.Count; i++)
					{
						if (!anchorUrls[i].StartsWith("http"))
						{
							anchorUrls[i] = url + anchorUrls[i];
						}
					}

					Parallel.ForEach(anchorUrls, src => Crawl(src));
					linkCounter += anchorUrls.Count;
				}
			}

			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine($"{url} crawled!");
			Console.WriteLine(linkCounter);
		}
	}
}