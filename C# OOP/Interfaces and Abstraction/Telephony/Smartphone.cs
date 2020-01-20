namespace Telephony
{
	using System;

	public class Smartphone : ICaller, IBrowser
	{
		public string Browsing(string url)
		{
			if(this.UrlValidator(url))
			{
				return $"Browsing: {url}!";
			}
			else
			{
				throw new ArgumentException("Invalid URL!");
			}
		}

		public string Calling(string number)
		{
			if(this.NumberValidator(number))
			{
				return $"Calling... {number}";
			}
			else
			{
				throw new ArgumentException("Invalid number!");
			}
		}

		private bool NumberValidator(string number)
		{
			for (int i = 0; i < number.Length; i++)
			{
				char num = number[i];

				if(char.IsLetter(num))
				{
					return false;
				}
			}

			return true;
		}

		private bool UrlValidator(string url)
		{
			for (int i = 0; i < url.Length; i++)
			{
				char letter = url[i];

				if (char.IsNumber(letter))
				{
					return false;
				}
			}

			return true;
		}
	}
}
