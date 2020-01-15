using System.Text;

namespace Cars
{
	public class Tesla : ICar, IElectricCar
	{
		public Tesla(string model, string color, int battery)
		{
			this.Model = model;
			this.Color = color;
			this.Battery = battery;
		}

		public string Model { get ; set; }
		public string Color { get ; set; }
		public int Battery { get; set; }

		public string Start()
		{
			return "Engine start";
		}

		public string Stop()
		{
			return "Breaaak!";
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine($"{this.Color} Tesla {this.Model} with {this.Battery} Batteries");
			sb.AppendLine(this.Start());
			sb.Append(this.Stop());

			return sb.ToString();
		}
	}
}
