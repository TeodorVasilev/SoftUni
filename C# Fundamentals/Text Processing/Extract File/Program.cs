namespace Extract_File
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine().Split('\\');

            string file = "";

            for (int i = 0; i < path.Length; i++)
            {
                if (path[i].Contains('.'))
                {
                    file = path[i];
                }
            }

            string[] fileExt = file.Split('.');

            Console.WriteLine($"File name: {fileExt[0]}");
            Console.WriteLine($"File extension: {fileExt[1]}");
        }
    }
}
