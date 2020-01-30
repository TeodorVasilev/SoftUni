namespace Encrypt__Sort_and_Print_Array
{
	using System;

    public class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			//65,69,73,79,85,97,101,105,111,117

			int[] codes = new int[n];

			for (int i = 0; i < n; i++)
			{
				string name = Console.ReadLine();

				int sum = 0;

				for (int j = 0; j < name.Length; j++)
				{
					if(name[j] == 65 || name[j] == 69 || name[j] == 73 || name[j] == 79 || name[j] == 85
						|| name[j] == 97 || name[j] == 101 || name[j] == 105 || name[j] == 111|| name[j] == 117)
					{
						sum += name[j] * name.Length;
					}
					else
					{
						sum += name[j] / name.Length;
					}
				}

				codes[i] = sum;
			}

			Array.Sort(codes);

			foreach (var code in codes)
			{
				Console.WriteLine(code);
			}
		}
	}
}
