namespace Courses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> courseNames = new Dictionary<string, List<string>>();

            while (input != "end")
            {
                string[] courseArgs = input.Split(" : ");

                string course = courseArgs[0];
                string name = courseArgs[1];

                if(!courseNames.ContainsKey(course))
                {
                    courseNames[course] = new List<string>();
                    courseNames[course].Add(name);
                }
                else
                {
                    courseNames[course].Add(name);
                }

                input = Console.ReadLine();
            }

            var sorted = courseNames.OrderByDescending(x => x.Value.Count);

            foreach (var kvp in sorted)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                foreach (var item in kvp.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
