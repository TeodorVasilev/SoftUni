using System.Text;

namespace P12._Google
{
	public class Pokemon
	{
		public Pokemon(string name, string element)
		{
			this.Name = name;
			this.Element = element;
		}

		public string Name { get; set; }

		public string Element { get; set; }

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("Pokemon:");
			sb.AppendLine($"{this.Name} {this.Element}");

			return sb.ToString();
		}
	}
}
