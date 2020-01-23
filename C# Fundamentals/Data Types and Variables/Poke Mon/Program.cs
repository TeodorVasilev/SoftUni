namespace Poke_Mon
{
	using System;
	public class Program
	{
		static void Main(string[] args)
		{
			int pokePower = int.Parse(Console.ReadLine());

			double halfPokePower = pokePower * 0.50;

			int distance = int.Parse(Console.ReadLine());
			
			int exhaustion = int.Parse(Console.ReadLine());

			int targetsCount = 0;

			while (pokePower >= distance)
			{
				if(pokePower == halfPokePower)
				{
					if(exhaustion != 0)
					{
						pokePower /= exhaustion;

						if(pokePower < distance)
						{
							break;
						}
					}
				}

				pokePower -= distance;
				targetsCount++;
			}

			Console.WriteLine(pokePower);
			Console.WriteLine(targetsCount);
		}
	}
}
