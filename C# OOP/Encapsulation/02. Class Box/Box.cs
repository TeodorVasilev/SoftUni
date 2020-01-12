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
			this.Length = length;
			this.Width = width;
			this.Height = height;
		}

		public double Length
		{
			get => this.length;

			private set
			{

				this.ValidateParameter(value, nameof(this.Width));

				this.length = value;
			}
		}

		public double Width
		{
			get => this.width;

			private set
			{

				this.ValidateParameter(value, nameof(this.Width));

				this.width = value;
			}
		}

		public double Height
		{
			get => this.height;

			private set
			{

				this.ValidateParameter(value, nameof(this.Width));

				this.height = value;
			}
		}

		private void ValidateParameter(double value, string parameter)
		{
			if (value <= 0)
			{
				throw new ArgumentException($"{parameter} cannot be zero or negative.");
			}
		}

		public double Volume()
		{
			return this.length * this.width * this.height;
		}

		public double LateralSurfaceArea()
		{
			return 2 * this.length * this.height + 2 * this.width * this.height;
		}

		public double SurfaceArea()
		{
			return 2 * this.length * this.width + 2 * this.length * this.height + 2 * this.width * this.height;
		}
	}
}
