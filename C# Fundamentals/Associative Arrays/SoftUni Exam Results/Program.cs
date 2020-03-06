namespace SoftUni_Exam_Results
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, int> userPoints = new Dictionary<string, int>();
            Dictionary<string, int> langSubs = new Dictionary<string, int>();

            while (input != "exam finished")
            {
                string[] userArgs = input.Split('-');

                if (userArgs.Length == 2)
                {
                    string user = userArgs[0];

                    if(userPoints.ContainsKey(user))
                    {
                        userPoints.Remove(user);
                    }
                }
                else if(userArgs.Length == 3)
                {
                    string user = userArgs[0];
                    string lang = userArgs[1];
                    int points = int.Parse(userArgs[2]);

                    if(!userPoints.ContainsKey(user))
                    {
                        userPoints[user] = 0;
                    }

                    if(userPoints[user] < points)
                        userPoints[user] = points;

                    if(!langSubs.ContainsKey(lang))
                    {
                        langSubs[lang] = 0;
                    }

                    langSubs[lang]++;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Results:");

            var sortedUserPoints = userPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            foreach (var kvp in sortedUserPoints)
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }

            Console.WriteLine("Submissions:");

            var sortedLangSubs = langSubs.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            foreach (var kvp in sortedLangSubs)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
