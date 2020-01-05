using System;
using System.Collections.Generic;
using System.Text;

namespace P12._Google
{
	class Person
	{
		public string Name { get; set; }

		public Company Company { get; set; }

		public Car Car { get; set; }

		public List<Parent> Parents { get; set; } = new List<Parent>();

		public List<Child> Children { get; set; } = new List<Child>();

		public List<Pokemon> Pokemons { get; set; } = new List<Pokemon>();
	}
}
