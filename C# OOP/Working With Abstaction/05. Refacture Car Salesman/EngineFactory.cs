namespace _05._Refacture_Car_Salesman
{
	public class EngineFactory
	{
		public Engine Create(string[] parameters)
		{
			string model = parameters[0];
			int power = int.Parse(parameters[1]);

			int displacement = -1;

			Engine engine = null;

			if (parameters.Length == 3 && int.TryParse(parameters[2], out displacement))
			{
				engine = new Engine(model, power, displacement);
			}
			else if (parameters.Length == 3)
			{
				string efficiency = parameters[2];
				engine = new Engine(model, power, efficiency);
			}
			else if (parameters.Length == 4)
			{
				string efficiency = parameters[3];
				engine = new Engine(model, power, int.Parse(parameters[2]), efficiency);
			}
			else
			{
				engine = new Engine(model, power);
			}

			return engine;
		}
	}
}
