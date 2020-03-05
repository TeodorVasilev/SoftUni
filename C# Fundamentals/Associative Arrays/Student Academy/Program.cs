namespace Student_Academy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> nameGrades = new Dictionary<string, List<double>>();   

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if(!nameGrades.ContainsKey(name))
                {
                    nameGrades[name] = new List<double>();
                    nameGrades[name].Add(grade);
                }
                else
                {
                    nameGrades[name].Add(grade);
                }
            }

            var filtered = nameGrades.Where(n => n.Value.Average() >= 4.50).OrderByDescending(n => n.Value.Average());

            foreach (var kvp in filtered)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():F2}");
            }
        }
    }
}
