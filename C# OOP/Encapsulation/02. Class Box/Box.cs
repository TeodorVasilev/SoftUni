namespace _02._Class_Box
{
	using System;

	public class Box
	{
		private double length;
		private double width;
		private double height;

		public Box(double length, double width, double height)
		{
			ValidateParameter(length, "Length");
			this.length = length;
			ValidateParameter(width, "Width");
			this.width = width;
			ValidateParameter(height, "Height");
			this.height = height;
		}

		public double SurfaceArea()
		{
			return 2 * (this.length * this.width) + this.LateralSurfaceArea();
		}

		public double LateralSurfaceArea()
		{
			return 2 * (this.length * this.height + this.width * this.height);
		}

		public double Volume()
		{
			return this.width * this.height * this.length;
		}

		private void ValidateParameter(double value, string parameter)
		{
			if (value <= 0)
			{
				throw new ArgumentException($"{parameter} cannot be zero or negative.");
			}
		}
	}
}
