namespace _06._Football_Team_Generator
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class Team
	{
		private string name;
		private List<Player> players;

		public Team(string name)
		{
			this.Name = name;
			this.players = new List<Player>();
		}

		public string Name
		{
			get => this.name;

			private set
			{
				if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("A name should not be empty.");
				}

				this.name = value;
			}
		}

		private int GetRating()
		{
			
			if (players.Count == 0)
			{
				return 0;
			}

			return (int)Math.Round(this.players.Average(p => p.Stats));
			
		}

		public Player GetPlayer(string playerName)
		{
			Player player = this.players.FirstOrDefault(p => p.Name == playerName);

			if (player == null)
			{
				throw new ArgumentException($"Player {playerName} is not in {this.Name} team.");
			}

			return player;
		}

		public void AddPlayer(Player player)
		{
			this.players.Add(player);
		}

		public void RemovePlayer(string playerName)
		{
			Player player = this.GetPlayer(playerName);

			if(player == null)
			{
				throw new ArgumentException($"Player {playerName} is not in {this.Name} team.");
			}

			this.players.Remove(player);
		}

		public override string ToString()
		{
			return $"{this.Name} - {this.GetRating()}";
		}
	}
}
