namespace _07._Refacture_Hospital
{
	using System.Collections.Generic;
	using System.Linq;

	public class Hospital
	{
		public Hospital()
		{
			this.Departments = new SortedSet<Department>(new DepartmentComparer());
			this.Doctors = new SortedSet<Doctor>(new DoctorComparer());
		}

		public SortedSet<Department> Departments { get; set; }

		public SortedSet<Doctor> Doctors { get; set; }

		public void AddDepartment(string departmentName)
		{
			Department department = new Department(departmentName);
			
			if(!this.Departments.Contains(department))
			{
				department.AddRoom();

				this.Departments.Add(department);
			}
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
				Room room = department.Rooms.Where(r => r.Patients.Count < 3).FirstOrDefault();

				room.Patients.Add(patient);
				
				doctor.AddPatient(patient);
			}
		}
	}
}
