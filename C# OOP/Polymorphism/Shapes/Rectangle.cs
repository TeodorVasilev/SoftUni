namespace Shapes
{
	using System;

	public class Rectangle : Shape
	{
		private double height;
		private double width;

		public Rectangle(double height, double width)
		{
			this.Height = height;
			this.Width = width;
		}

		public double Height 
		{
			get => this.height;

			private set
			{
				if(value <= 0)
				{
					throw new ArgumentException("Height cannot be zero or negative.");
				}

				this.height = value;
			}
		}
		public double Width
		{
			get => this.width;

			private set
			{
				if (value <= 0)
				{
					throw new ArgumentException("Width cannot be zero or negative.");
				}

				this.width = value;
			}
		}

		public override double CalculateArea()
		{
			return this.Width * this.Height;
		}

		public override double CalculatePerimeter()
		{
			return 2 * (this.Width + this.Height);
		}

		public override string Draw()
		{
			return base.Draw() + this.GetType().Name; 
		}
	}
}
