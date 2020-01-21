using System.Collections.Generic;

namespace MilitaryElite
{
	public interface ICommando
	{
		IReadOnlyCollection<Mission> Missions { get; }

		void CompleteMission(string codeName);
	}
}
