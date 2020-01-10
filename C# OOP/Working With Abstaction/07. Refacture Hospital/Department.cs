namespace _07._Refacture_Hospital
{
	using System.Collections.Generic;
	using System.Linq;

	public class Department
	{
		private const int roomCount = 20;

		public Department(string name)
		{
			this.Name = name;
			this.Rooms = new List<Room>();
		}

		public string Name { get; set; }

		public List<Room> Rooms { get; set; }

		public void AddRoom()
		{
			if(this.Rooms.Count < 20)
			{
				int number = this.Rooms.Count + 1;

				this.Rooms.Add(new Room(number));
			}
		}

		public bool CheckForFreePlace()
		{
			if (this.Rooms.Count <= 20)
			{
				for (int i = 0; i < this.Rooms.Count; i++)
				{
					Room room = Rooms[i];

					if (room.ChekForFreeBed())
					{
						return true;
					}
				}
			}

			return false;
		}
	}
}
