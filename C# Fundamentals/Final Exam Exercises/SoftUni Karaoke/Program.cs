namespace SoftUni_Karaoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> songs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Dictionary<string, List<string>> participantAwards = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "dawn")
            {
                string[] splited = input.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string participant = splited[0];
                string song = splited[1];
                string award = splited[2];

                if(participants.Contains(participant) && songs.Contains(song))
                {
                    if(!participantAwards.ContainsKey(participant))
                    {
                        participantAwards[participant] = new List<string>();
                        participantAwards[participant].Add(award);
                    }
                    else
                    {
                        if(!participantAwards[participant].Contains(award))
                        {
                            participantAwards[participant].Add(award);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            if(participantAwards.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                var sorted = participantAwards.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key);

                foreach (var kvp in sorted)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value.Count} awards");

                    foreach (var item in kvp.Value.OrderBy(x=>x))
                    {
                        Console.WriteLine($"--{item}");
                    }
                }
            }
        }
    }
}
