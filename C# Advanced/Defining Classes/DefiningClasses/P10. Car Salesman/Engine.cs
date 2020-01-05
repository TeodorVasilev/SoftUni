using System;
using System.Collections.Generic;
using System.Text;

namespace P10._Car_Salesman
{
	public class Engine
	{
		private string model;

		private int power;

		private int displacement;

		private string efficiency;

		private const string DefaultValueString = "n/a";
		private const int DefaultValueInt = -1;

		public Engine(string model, int power, int displacement, string efficiency)
		{
			this.Model = model;
			this.Power = power;
			this.Displacement = displacement;
			this.Efficiency = efficiency;
		}

		public Engine(string model, int power, int displacement)
			:this(model, power, displacement, DefaultValueString)
		{
		}

		public Engine(string model, int power, string efficiency)
			: this(model, power, DefaultValueInt, efficiency)
		{
		}

		public Engine(string model, int power)
			: this(model, power, DefaultValueInt, DefaultValueString)
		{
		}

		public string Efficiency
		{
			get { return efficiency; }
			set { efficiency = value; }
		}

		public int Displacement
		{
			get { return displacement; }
			set { displacement = value; }
		}

		public int Power
		{
			get { return power; }
			set { power = value; }
		}

		public string Model
		{
			get { return model; }
			set { model = value; }
		}
	}
}
