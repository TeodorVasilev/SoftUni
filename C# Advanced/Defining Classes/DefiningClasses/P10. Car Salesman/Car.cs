using System.Text;

namespace P10._Car_Salesman
{
	public class Car
	{
		private string model;

		private Engine engine;

		private int weight;

		private string color;

		private const string DefaultValueString = "n/a";
		private const int DefaultValueInt = -1;

		public Car(string model, Engine engine, int weight, string color)
		{
			this.Model = model;
			this.Engine = engine;
			this.Weight = weight;
			this.Color = color;
		}

		public Car(string model, Engine engine, int weight)
			: this(model, engine, weight, DefaultValueString)
		{
		}

		public Car(string model, Engine engine, string color)
			: this(model, engine, DefaultValueInt, color)
		{
		}

		public Car(string model, Engine engine)
			: this(model, engine, DefaultValueInt, DefaultValueString)
		{
		}

		public string Color
		{
			get { return color; }
			set { color = value; }
		}

		public int Weight
		{
			get { return weight; }
			set { weight = value; }
		}

		public Engine Engine
		{
			get { return engine; }
			set { engine = value; }
		}

		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"{this.Model}");
			sb.AppendLine($" {this.Engine.Model}:");
			sb.AppendLine($"  Power: {this.Engine.Power}");
			if (this.Engine.Displacement < 1)
				sb.AppendLine($"  Displacement: n/a");
			else
				sb.AppendLine($"  Displacement: {this.Engine.Displacement}");
			sb.AppendLine($"  Efficiency: {this.Engine.Efficiency}");
			if (this.Weight < 1)
				sb.AppendLine($"Weight: n/a");
			else
				sb.AppendLine($"Weight: {this.Weight}");
			sb.AppendLine($"Color: {this.Color}");

			return sb.ToString();
		}
	}
}
