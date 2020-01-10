namespace _07._Refacture_Hospital
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class Hospital
	{
		public Hospital()
		{
			this.Departments = new HashSet<Department>();
			this.Doctors = new HashSet<Doctor>();
		}

		public HashSet<Department> Departments { get; set; }

		public HashSet<Doctor> Doctors { get; set; }

		public void AddDepartment(string departmentName)
		{
			Department department = new Department(departmentName);

			for (int i = 1; i <= 20; i++)
			{
				department.AddRoom();
			}
			
			this.Departments.Add(department);
		}

		public void AddDoctor(string firstName, string lastName)
		{
			Doctor doctor = new Doctor(firstName, lastName);

			if (!this.Doctors.Contains(doctor))
			{
				this.Doctors.Add(doctor);
			}
		}

		public void AddPatient(string name, string departmentName, string doctorFirstName, string doctorLastName)
		{
			Patient patient = new Patient(name);

			Department department = Departments.Where(d => d.Name == departmentName).FirstOrDefault();

			Doctor doctor = Doctors.Where(d => d.FirstName == doctorFirstName &&
			d.LastName == doctorLastName).FirstOrDefault();
			
			if(department.CheckForFreePlace())
			{
				Room room = department.Rooms.Where(r => r.Beds.Count < 3).FirstOrDefault();

				room.Beds.Add(new Bed(name));
				
				doctor.AddPatient(patient);
			}
		}
	}
}
