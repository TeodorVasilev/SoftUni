namespace Shapes
{
	using System;
	using System.Text;

	public class Circle : IDrawable
	{
		private int radius;

		public Circle(int radius)
		{
			this.Radius = radius;
		}

		public int Radius
		{
			get => this.radius;

			private set
			{
				if (value <= 0)
				{
					throw new ArgumentException();
				}

				this.radius = value;
			}
		}

		public string Draw()
		{
			StringBuilder sb = new StringBuilder();
			double radiusIn = this.Radius - 0.4;
			double radiusOut = this.Radius + 0.4;

			for (double i = this.Radius; i >= -this.Radius; --i)
			{
				for (double t = -this.Radius; t < radiusOut; t += 0.5)
				{
					double value = t * t + i * i;

					if(value >= radiusIn * radiusIn && value <= radiusOut * radiusOut)
					{
						sb.Append('*');
					}
					else
					{
						sb.Append(' ');
					}
				}

				sb.AppendLine();
			}

			return sb.ToString();
		}
	}
}
