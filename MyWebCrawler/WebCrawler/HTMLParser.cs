namespace WebCrawler
{
	using System.Collections.Generic;
	using System.Text.RegularExpressions;

	public class HTMLParser
	{
		public List<string> GetImgSrcs(string html)
		{
			string pattern = "<img.+?src=\"(.+?)\".*?>";
			Regex rgx = new Regex(pattern);
			List<string> imgUrls = new List<string>();

			foreach (Match match in rgx.Matches(html))
			{
				imgUrls.Add(match.Groups[1].Value);
			}

			return imgUrls;
		}

		public List<string> GetAnchorUrls(string html)
		{
			string pattern = "<a.+?href=\"(.+?)\">";
			Regex rgx = new Regex(pattern);
			List<string> anchorTags = new List<string>();

			foreach (Match match in rgx.Matches(html))
			{
				anchorTags.Add(match.Groups[1].Value);
			}

			return anchorTags;
		}
	}
}
