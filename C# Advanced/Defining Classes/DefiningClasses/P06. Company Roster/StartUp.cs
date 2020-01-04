using System;
using System.Collections.Generic;
using System.Linq;

namespace P06._Company_Roster
{
	class StartUp
	{
		static void Main(string[] args)
		{
			int numberOfEmployees = int.Parse(Console.ReadLine());

			List<Employee> employees = new List<Employee>();

			for (int i = 0; i < numberOfEmployees; i++)
			{
				string[] employeeArgs = Console.ReadLine().Split().ToArray();
				
				string name = employeeArgs[0];
				decimal salary = decimal.Parse(employeeArgs[1]);
				string position = employeeArgs[2];
				string department = employeeArgs[3];

				if(employeeArgs.Length == 4)
				{
					Employee employee = new Employee(name, salary, position, department);

					employees.Add(employee);
				}
				else if(employeeArgs.Length == 5)
				{
					if(employeeArgs[4].Contains("@"))
					{
						string email = employeeArgs[4];

						Employee employee = new Employee(name, salary, position, department,email);

						employees.Add(employee);
					}
					else
					{
						int age = int.Parse(employeeArgs[4]);

						Employee employee = new Employee(name, salary, position, department, age);

						employees.Add(employee);
					}
				}
				else if(employeeArgs.Length == 6)
				{
					string email = employeeArgs[4];
					int age = int.Parse(employeeArgs[5]);

					Employee employee = new Employee(name, salary, position, department, email, age);

					employees.Add(employee);
				}
			}

			string bestDeptAverageSalary = employees
				.GroupBy(e => e.Department)
				.Select(g => new { Department = g.Key, AverageSalary = g.Average(e => e.Salary) })
				.OrderByDescending(e => e.AverageSalary)
				.First()
				.Department;

			Console.WriteLine($"Highest Average Salary: {bestDeptAverageSalary}");

			employees
				.Where(e => e.Department == bestDeptAverageSalary)
				.OrderByDescending(e => e.Salary)
				.ToList()
				.ForEach(Console.WriteLine);
		}
	}
}
