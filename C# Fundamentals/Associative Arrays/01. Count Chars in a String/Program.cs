namespace _01.Count_Chars_in_a_String
{
	using System;
    using System.Collections.Generic;

    class Program
	{
		static void Main(string[] args)
		{
			char[] letters = Console.ReadLine().ToCharArray();

			Dictionary<char, int> letCnt = new Dictionary<char, int>();

			for (int i = 0; i < letters.Length; i++)
			{
				if(letters[i] != ' ')
				{
					if(!letCnt.ContainsKey(letters[i]))
					{
						letCnt[letters[i]] = 1;
					}
					else
					{
						letCnt[letters[i]]++;
					}
				}
			}

			foreach (var kvp in letCnt)
			{
				Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
			}
		}
	}
}
