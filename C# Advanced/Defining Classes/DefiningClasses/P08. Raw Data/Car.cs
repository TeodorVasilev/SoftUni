using System.Text;

namespace P08._Raw_Data
{
	public class Car
	{
		private string model;

		private Engine engine;// = new Engine();

		private Cargo cargo;// = new Cargo();

		private Tire[] tires;// = new Tire[4];
		
		public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
		{
			this.Model = model;
			this.Engine = engine;
			this.Cargo = cargo;
			this.Tires = tires;
		}

		public Tire[] Tires
		{
			get { return tires; }
			set { tires = value; }
		}

		public Cargo Cargo
		{
			get { return cargo; }
			set { cargo = value; }
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
			sb.Append($"{this.Model}");
			return sb.ToString();
		}
	}
}
