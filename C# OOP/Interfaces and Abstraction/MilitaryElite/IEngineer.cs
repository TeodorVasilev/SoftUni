using System.Collections.Generic;

namespace MilitaryElite
{
	public interface IEngineer
	{
		IReadOnlyCollection<Repair> Repairs { get; }

	}
}
