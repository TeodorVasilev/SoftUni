using System.Collections.Generic;
using System.Text;

namespace P11._Pokemon_Trainer
{
	public class Trainer
	{
		private List<Pokemon> pokemons = new List<Pokemon>();

		public Trainer(string name)
		{
			this.Name = name;
		}

		public string Name { get; set; }

		public int Badges { get; set; }

		public List<Pokemon> Pokemons { get; set; }

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append($"{this.Name} {this.Badges} {this.Pokemons.Count}");

			return sb.ToString();
		}
	}
}
