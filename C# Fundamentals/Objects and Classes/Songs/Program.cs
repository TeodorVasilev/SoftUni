namespace Songs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] songArgs = Console.ReadLine().Split('_');

                string type = songArgs[0];
                string name = songArgs[1];
                string time = songArgs[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }

            string printType = Console.ReadLine();

            if(printType == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songs.Where(x => x.TypeList == printType))
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
}
