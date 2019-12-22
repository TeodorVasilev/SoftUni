using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			var wardrobe = new Dictionary<string, Dictionary<string,int>>();

			for (int i = 0; i < n; i++)
			{
				string[] colorClothes = Console.ReadLine().Split(new string[] {" -> "},StringSplitOptions.RemoveEmptyEntries);
				string color = colorClothes[0];
				string[] clothes = colorClothes[1].Split(',');

				if(!wardrobe.ContainsKey(color))
				{
					wardrobe[color] = new Dictionary<string, int>();
				}

				for (int k = 0; k < clothes.Length; k++)
				{
					string cloth = clothes[k];
					if(!wardrobe[color].ContainsKey(cloth))
					{
						wardrobe[color][cloth] = 1;
					}
					else
					{
						wardrobe[color][cloth]++;
					}
				}
			}

			string[] search = Console.ReadLine().Split();

			string colorToSearch = search[0];
			string clothToSearch = search[1];

			foreach (var kvp in wardrobe)
			{
				string color = kvp.Key;
				var clothCount = kvp.Value;

				Console.WriteLine($"{color} clothes:");

				foreach (var kvpClothCount in clothCount)
				{
					string cloth = kvpClothCount.Key;
					int count = kvpClothCount.Value;
					
					if(color == colorToSearch && cloth == clothToSearch)
					{
						Console.WriteLine($"* {cloth} - {count} (found!)");
					}
					else
					{
						Console.WriteLine($"* {cloth} - {count}");
					}
				}
			}
		}
	}
}
