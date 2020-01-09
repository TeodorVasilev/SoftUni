namespace P02._Point_in_Rectangle
{
	using System;
	using System.Linq;

	class Program
	{
		static void Main(string[] args)
		{
			int[] rectangleCoordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();

			var topLeftX = rectangleCoordinates[0];
			var topLeftY = rectangleCoordinates[1];
			var botRightX = rectangleCoordinates[2];
			var botRightY = rectangleCoordinates[3];

			var topLeftPoint = new Point(topLeftX, topLeftY);
			var botRightPoint = new Point(botRightX, botRightY);

			var rectangle = new Rectangle(topLeftPoint, botRightPoint);

			int pointsCount = int.Parse(Console.ReadLine());

			for (int i = 0; i < pointsCount; i++)
			{
				int[] pointsCoordiantes = Console.ReadLine().Split().Select(int.Parse).ToArray();

				int pointX = pointsCoordiantes[0];
				int pointY = pointsCoordiantes[1];

				var point = new Point(pointX, pointY);

				Console.WriteLine(rectangle.Contains(point));
			}
		}
	}
}
