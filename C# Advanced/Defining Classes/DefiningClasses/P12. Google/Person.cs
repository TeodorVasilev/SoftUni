using System.Collections.Generic;
using System.Text;

namespace P12._Google
{
	public class Person
	{
		public string Name { get; set; }

		public Company Company { get; set; }

		public Car Car { get; set; }

		public List<Parent> Parents { get; set; } = new List<Parent>();

		public List<Child> Children { get; set; } = new List<Child>();

		public List<Pokemon> Pokemons { get; set; } = new List<Pokemon>();

		public Person(string name)
		{
			this.Name = name;
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine($"{this.Name}");
			sb.AppendLine($"Company:");
			if (this.Company != null)
				sb.AppendLine($"{this.Company.Name} {this.Company.Department} {this.Company.Salary}");
			sb.AppendLine($"Car:");
			if (this.Car != null)
				sb.AppendLine($"{this.Car.Model} {this.Car.Speed}");
			return sb.ToString();
		}
	}
}
