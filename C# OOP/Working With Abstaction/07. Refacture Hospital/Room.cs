namespace _07._Refacture_Hospital
{
	using System.Collections.Generic;
	using System.Linq;

	public class Room
	{
		private const int bedsCount = 3;

		public Room(int number)
		{
			this.Number = number;
			this.Beds = new List<Bed>();
		}

		public int Number { get; set; }

		public List<Bed> Beds { get; set; }

		public bool ChekForFreeBed()
		{
			if (this.Beds.Count < 3)
			{
				return true;
			}

			return false;
		}
	}
}
