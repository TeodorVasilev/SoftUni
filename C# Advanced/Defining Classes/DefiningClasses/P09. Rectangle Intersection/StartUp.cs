using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09.Rectangle_Intersection
{
	class StartUp
	{
		static void Main(string[] args)
		{
			int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

			int numberOfRects = input[0];
			int intsecChecks = input[1];

			List<Rectangle> rectangles = new List<Rectangle>();

			for (int i = 0; i < numberOfRects; i++)
			{
				string[] inputParts = Console.ReadLine().Split().ToArray();

				string id = inputParts[0];
				int width = int.Parse(inputParts[1]);
				int height = int.Parse(inputParts[2]);
				int x = int.Parse(inputParts[3]);
				int y = int.Parse(inputParts[4]);

				Point topLeft = new Point(x, y);
				Point botRight = new Point(width, height);

				Rectangle rectangle = new Rectangle(id, width, height, topLeft, botRight);

				rectangles.Add(rectangle);
			}
			
			for (int i = 0; i < intsecChecks; i++)
			{
				string[] pairsToChek = Console.ReadLine().Split();

				string firstId = pairsToChek[0];
				string secondId = pairsToChek[1];

				Rectangle first = rectangles.Where(r => r.Id == firstId).FirstOrDefault();
				Rectangle second = rectangles.Where(r => r.Id == secondId).FirstOrDefault();

				Console.WriteLine(first.IntersectionChek(second));
			}
		}
	}
}
