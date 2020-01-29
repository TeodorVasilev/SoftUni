namespace Common_Elements
{
	using System;

	public class Program
	{
		static void Main(string[] args)
		{
			string[] firstArr = Console.ReadLine().Split(" ");
			string[] secondArr = Console.ReadLine().Split(" ");

			for (int i = 0; i < secondArr.Length; i++)
			{
				for (int k = 0; k < firstArr.Length; k++)
				{
					if(secondArr[i] == firstArr[k])
					{
						Console.Write(secondArr[i] + " ");
					}
				}
			}
		}
	}
}
