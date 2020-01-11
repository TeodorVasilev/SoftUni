namespace _07._Refacture_Hospital
{
	using System;
	using System.Linq;

	public class Program
	{
		static void Main(string[] args)
		{
			Hospital hospital = new Hospital();

			string input = Console.ReadLine();

			while (input != "Output")
			{
				string[] inputParts = input.Split();

				string departmentName = inputParts[0];

				hospital.AddDepartment(departmentName);

				string doctorFirstName = inputParts[1];
				string doctorLastName = inputParts[2];

				hospital.AddDoctor(doctorFirstName, doctorLastName);

				string patientName = inputParts[3];

				hospital.AddPatient(patientName, departmentName, doctorFirstName, doctorLastName);

				input = Console.ReadLine();
			}

			input = Console.ReadLine();

			while (input != "End")
			{
				string[] inputParts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

				if(inputParts.Length == 1)
				{
					var department = hospital.Departments.Where(d => d.Name == inputParts[0]);

					var rooms = department.SelectMany(r => r.Rooms);

					foreach (var room in rooms)
					{
						foreach (var patient in room)
						{
							Console.WriteLine(patient);
						}
					}
				}
				else
				{
					bool isDepartment = int.TryParse(inputParts[1], out int roomNumber);
					string departmentName = inputParts[0];

					if(isDepartment)
					{
						var department = hospital.Departments.Where(d => d.Name == departmentName);

						var room = department.SelectMany(d => d.Rooms).Where(r => r.Number == roomNumber).FirstOrDefault();

						var patients = room.Patients.OrderBy(x => x.Name);

						foreach (var patient in patients)
						{
							Console.WriteLine(patient);
						}
					}
					else
					{
						string doctorFirstName = inputParts[0];
						string doctorLastName = inputParts[1];

						var doctor = hospital.Doctors.Where(d => d.FirstName == doctorFirstName && d.LastName == doctorLastName).FirstOrDefault();

						var patients = doctor.Patients.OrderBy(p => p.Name);

						foreach (var patient in patients)
						{
							Console.WriteLine(patient);
						}
					}
				}

				input = Console.ReadLine();
			}
		}
	}
}
