namespace Snowballs
{
	using System;
    using System.Numerics;

    public class Program
	{
		static void Main(string[] args)
		{
			int snowballsCount = int.Parse(Console.ReadLine());

			BigInteger highestSnowballValue = long.MinValue;
			int highestSnowballSnow = 0;
			int highestSnowballTime = 0;
			int highestSnowballQuality = 0;

			for (int i = 0; i < snowballsCount; i++)
			{
				int snowballSnow = int.Parse(Console.ReadLine());
				int snowballTime = int.Parse(Console.ReadLine());
				int snowballQuality = int.Parse(Console.ReadLine());

				BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

				if (snowballValue > highestSnowballValue)
				{
					highestSnowballValue = snowballValue;
					highestSnowballSnow = snowballSnow;
					highestSnowballTime = snowballTime;
					highestSnowballQuality = snowballQuality;
				}
			}

			Console.WriteLine($"{highestSnowballSnow} : {highestSnowballTime} = {highestSnowballValue} ({highestSnowballQuality})");
		}
	}
}
