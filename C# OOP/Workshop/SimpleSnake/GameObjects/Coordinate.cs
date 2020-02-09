using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects
{
	public class Coordinate
	{
		public Coordinate(int coordinateX, int coordinateY)
		{
			this.CoordinateX = coordinateX;
			this.CoordinateY = coordinateY;
		}

		public int CoordinateX { get; set; }

		public int CoordinateY { get; set; }
	}
}
