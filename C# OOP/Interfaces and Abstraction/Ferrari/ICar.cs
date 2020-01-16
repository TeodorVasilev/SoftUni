namespace Ferrari
{
	public interface ICar
	{
		string DriverName { get; }

		string Model { get; }

		string Accelerate();

		string Brake();
	}
}
