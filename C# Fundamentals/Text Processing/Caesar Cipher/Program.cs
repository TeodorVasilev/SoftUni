namespace Caesar_Cipher
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine().ToCharArray();

            char[] encoded = text.Select(x => (char)(x + 3)).ToArray();

            Console.WriteLine(new string(encoded));
        }
    }
}
