namespace _05._Refacture_Car_Salesman
{
	using System.Collections.Generic;

	public class CarCatalog
	{
		public CarCatalog()
		{
			this.Cars = new List<Car>();
		}

		public List<Car> Cars { get; set; }

		public void Add(Car car)
		{
			Cars.Add(car);
		}

	}
}
