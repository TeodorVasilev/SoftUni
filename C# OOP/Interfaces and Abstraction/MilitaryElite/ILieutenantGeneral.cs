namespace MilitaryElite
{
	using System.Collections.Generic;

	public interface ILieutenantGeneral
	{
		IReadOnlyCollection<Private> Privates { get; }
	}
}
