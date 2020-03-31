namespace Song_Encryption
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<name>^[A-Z]{1}[a-z?' ]+):(?<song>[A-Z ]+)";

            string input = Console.ReadLine();

            while (input != "end")
            {
                MatchCollection matches = Regex.Matches(input, pattern);

                string artist = "";
                string song = "";

                foreach (Match match in matches)
                {
                    artist = match.Groups["name"].Value;
                    song = match.Groups["song"].Value;
                }

                if(Regex.IsMatch(input, pattern))
                {
                    int key = artist.Length;

                    char[] encArtist = artist.ToCharArray();
                    char[] encSong = song.ToCharArray();

                    for (int i = 0; i < encArtist.Length; i++)
                    {
                        int result = encArtist[i] + key;

                        if (encArtist[i] == '\'' || encArtist[i] == ' ')
                        {
                            continue;
                        }
                        else if (char.IsUpper(encArtist[i]) && result > 90)
                        {
                            result = 64 + (encArtist[i] + key - 90);
                        }
                        else if(char.IsLower(encArtist[i]) && result > 122)
                        {
                            result = 96 + (encArtist[i] + key - 122);
                        }

                        encArtist[i] = (char)result;
                    }

                    for (int i = 0; i < encSong.Length; i++)
                    {
                        int result = encSong[i] + key;

                        if(encSong[i] == '\'' || encSong[i] == ' ')
                        {
                            continue;
                        }
                        else if (char.IsUpper(encSong[i]) && result > 90)
                        {
                            result = 64 + (encSong[i] + key - 90);
                        }
                        else if (char.IsLower(encSong[i]) && result > 122)
                        {
                            result = 96 + (encSong[i] + key - 122);
                        }

                        encSong[i] = (char)result;
                    }

                    Console.WriteLine($"Successful encryption: {new string(encArtist)}@{new string(encSong)}");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                input = Console.ReadLine();
            }
        }
    }
}
