using System;
using System.Collections.Generic;
using System.Text;

namespace P08._Raw_Data
{
	public class Tire
	{
		private double pressure;
		
		private int age;
		
		public Tire(double pressure, int age)
		{
			this.Pressure = pressure;
			this.Age = age;
		}

		public double Pressure
		{
			get { return pressure; }
			set { pressure = value; }
		}
		
		public int Age
		{
			get { return age; }
			set { age = value; }
		}
	}
}
