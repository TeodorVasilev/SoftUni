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

				}
				else
				{

				}

				input = Console.ReadLine();
			}
		}
	}
}
