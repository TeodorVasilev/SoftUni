namespace _05._Refacture_Car_Salesman
{
	using System.Collections.Generic;
	using System.Linq;

	public class CarFactory
	{
		public Car Create(string[] parameters, List<Engine> engines)
		{
			string model = parameters[0];
			string engineModel = parameters[1];

			Engine engine = engines.FirstOrDefault(x => x.Model == engineModel);

			Car car = null;

			int weight = -1;

			if (parameters.Length == 3 && int.TryParse(parameters[2], out weight))
			{
				car = new Car(model, engine, weight);
			}
			else if (parameters.Length == 3)
			{
				string color = parameters[2];
				car = new Car(model, engine, color);
			}
			else if (parameters.Length == 4)
			{
				string color = parameters[3];
				car = new Car(model, engine, int.Parse(parameters[2]), color);
			}
			else
			{
				car = new Car(model, engine);
			}

			return car;
		}
	}
}
