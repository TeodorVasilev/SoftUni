using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Person
{
	public class Person
	{
		private string name;
		private int age;

		public Person(string name, int age)
		{
			this.name = name;
			this.Age = age;
		}

		public int Age
		{
			get => this.age;

			private set
			{
				if(value < 0)
				{
					throw new ArgumentException("Age should not be negative.");
				}
				this.age = value;
			}
		}

		public override string ToString()
		{
			return $"Name: {this.name}, Age: {this.Age}";
		}
	}
}
