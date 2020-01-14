namespace _06._Football_Team_Generator
{
	using System;

	public class Player
	{
		private const int statsCount = 5;

		private string name;
		private int endurance;
		private int sprint;
		private int dribble;
		private int passing;
		private int shooting;

		public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
		{
			this.Name = name;
			this.Endurance = endurance;
			this.Sprint = sprint;
			this.Dribble = dribble;
			this.Passing = passing;
			this.Shooting = shooting;
		}

		public int Stats
		{
			get
			{
				return this.CalculateOverall();
			}
		}

		public int Shooting
		{
			get => this.shooting;

			private set
			{
				ValidateStats(value, nameof(this.Shooting));

				this.shooting = value;
			}
		}

		public int Passing
		{
			get => this.passing;

			private set
			{
				ValidateStats(value, nameof(this.Passing));

				this.passing = value;
			}
		}

		public int Dribble
		{
			get => this.dribble;

			private set
			{
				ValidateStats(value, nameof(this.Dribble));

				this.dribble = value;
			}
		}

		public int Sprint
		{
			get => this.sprint;

			private set
			{
				ValidateStats(value, nameof(this.Sprint));

				this.sprint = value;
			}
		}

		public int Endurance
		{
			get => this.endurance;

			private set
			{
				ValidateStats(value, nameof(this.Endurance));

				this.endurance = value;
			}
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
		
		private int CalculateOverall()
		{
			return (int)Math.Round((this.Dribble + this.Endurance + this.Passing + this.Shooting + this.Sprint) / (double)5);
		}
		
		private void ValidateStats(double parameter, string parameterName)
		{
			if(parameter < 0 || parameter > 100)
			{
				throw new ArgumentException($"{parameterName} should be between 0 and 100.");
			}
		}
	}
}
