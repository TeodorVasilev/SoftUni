namespace Valid_Usernames
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ").Where(u => ValidateUsername(u)).ToArray();

            foreach (var username in names)
            {
                Console.WriteLine(username);
            }
        }

        public static bool ValidateUsername(string username)
        {
            if(username.Length < 3 || username.Length > 16)
            {
                return false;
            }

            bool isValid = true;

            for (int i = 0; i < username.Length; i++)
            {
                char current = username[i];

                if(!(char.IsLetterOrDigit(current) || current == '_' || current == '-'))
                {
                    isValid = false;
                    break;
                }
            }

            return isValid;
        }
    }
}
