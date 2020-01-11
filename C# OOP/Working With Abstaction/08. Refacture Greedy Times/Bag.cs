namespace _08._Refacture_Greedy_Times
{
	using System.Collections.Generic;
	using System.Text;

	public class Bag
	{
		private long capacity;

		public Bag(long capacity)
		{
			this.capacity = capacity;
			this.GoldQuantity = GoldQuantity;
			this.GemQuantity = GemQuantity;
			this.CashQuantity = CashQuantity;
			this.ItemQuantity = new Dictionary<string, int>();
			this.OverallQuantity = OverallQuantity;
		}

		public Dictionary<string, int> ItemQuantity { get; set; }

		public long GoldQuantity { get; set; }

		public long GemQuantity { get; set; }

		public long CashQuantity { get; set; }

		public long OverallQuantity { get; set; }

		public void Add(string item, int quantity)
		{
			if(CheckCapacity(quantity))
			{
				if (item.Length == 3)
				{
					if (this.CashQuantity + quantity <= this.GemQuantity)
					{
						if(this.ItemQuantity.ContainsKey(item))
						{
							this.ItemQuantity[item] += quantity;
						}
						else
						{
							ItemQuantity.Add(item, quantity);
						}

						this.CashQuantity += quantity;

						this.OverallQuantity += quantity;
					}
				}
				else if (item.EndsWith("gem"))
				{
					if(this.GemQuantity + quantity <= this.GoldQuantity)
					{
						if(this.ItemQuantity.ContainsKey(item))
						{
							this.ItemQuantity[item] += quantity;
						}
						else
						{
							this.ItemQuantity.Add(item, quantity);
						}

						this.GemQuantity += quantity;

						this.OverallQuantity += quantity;
					}
				}
				else if (item.ToLower() == "gold")
				{
					if(this.ItemQuantity.ContainsKey(item))
					{
						this.ItemQuantity[item] += quantity;
					}
					else
					{
						this.ItemQuantity.Add(item, quantity);
					}

					this.GoldQuantity += quantity;

					this.OverallQuantity += quantity;
				}
			}
		}

		public bool CheckCapacity(int quantity)
		{
			if(this.OverallQuantity <= this.OverallQuantity + quantity)
			{
				return true;
			}

			return false;
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			if (this.GoldQuantity != 0)
				sb.AppendLine($"<Gold> ${this.GoldQuantity}");

			foreach (var kvp in this.ItemQuantity)
			{
				if(kvp.Key.ToLower() == "gold")
				sb.AppendLine($"##{kvp.Key} - {kvp.Value}");
			}

			if (this.GemQuantity != 0)
				sb.AppendLine($"<Gem> ${this.GemQuantity}");

			foreach (var kvp in this.ItemQuantity)
			{
				if (kvp.Key.EndsWith("gem"))
					sb.AppendLine($"##{kvp.Key} - {kvp.Value}");
			}

			if (this.CashQuantity != 0)
				sb.AppendLine($"<Cash> ${this.CashQuantity}");

			foreach (var kvp in this.ItemQuantity)
			{
				if(kvp.Key.Length == 3)
					sb.AppendLine($"##{kvp.Key} - {kvp.Value}");
			}

			return sb.ToString();
		}
	}
}
