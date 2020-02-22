namespace Students_2._0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] studentArgs = Console.ReadLine().Split();

                string firstName = studentArgs[0];
                string lastName = studentArgs[1];
                double grade = double.Parse(studentArgs[2]);

                Student student = new Student(firstName, lastName, grade);

                students.Add(student);
            }

            List<Student> sortedByGrade = students.OrderByDescending(x => x.Grade).ToList();

            foreach (var student in sortedByGrade)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
