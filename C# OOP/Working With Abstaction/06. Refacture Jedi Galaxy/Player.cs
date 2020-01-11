using System;
using System.Collections.Generic;
using System.Text;

namespace Refacture_Jedi_Galaxy
{
	public class Player
	{
		public Player(string name, Point position)
		{
			this.Name = name;
			this.Position = position;
		}
		
		public string Name { get; set; }

		public Point Position { get; set; }
	}
}
