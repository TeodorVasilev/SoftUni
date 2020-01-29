namespace Top_Integers
{
	using System;
    using System.Linq;

    public class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

			for (int i = 0; i < numbers.Length; i++)
			{
				int num = numbers[i];

				bool isTop = true;

				for (int k = i; k < numbers.Length - 1; k++)
				{
					if (num <= numbers[k + 1])
					{
						isTop = false;
						break;
					}
				}
				if(isTop == true)
				{
					Console.Write(num + " ");
				}
			}
		}
	}
}
