namespace Order_by_Age
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Person> people = new List<Person>();

            while (input != "End")
            {
                string[] personArgs = input.Split();

                string name = personArgs[0];
                string id = personArgs[1];
                int age = int.Parse(personArgs[2]);

                Person person = new Person(name, id, age);

                people.Add(person);

                input = Console.ReadLine();
            }

            var sorted = people.OrderBy(p => p.Age).ToList();

            foreach (var person in sorted)
            {
                Console.WriteLine(person);
            }
        }
    }
}
