namespace _07._Refacture_Hospital
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public class Department : IEnumerable<Room>
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
			int number = this.Rooms.Count + 1;

			if (this.Rooms.Count < 20)
			{
				this.Rooms.Add(new Room(number));
			}
			else
			{
				throw new InvalidOperationException("There are no free places int this department!");
			}
		}

		public bool CheckForFreePlace()
		{
			for (int i = 0; i < this.Rooms.Count; i++)
			{
				Room room = Rooms[i];

				if (room.ChekForFreePlace())
				{
					return true;
				}
				else
				{
					this.AddRoom();
					continue;
				}
			}

			return false;
		}
		
		public IEnumerator<Room> GetEnumerator()
		{
			for (int i = 0; i < this.Rooms.Count; i++)
			{
				yield return this.Rooms[i];
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
			=> this.GetEnumerator();
	}
}
