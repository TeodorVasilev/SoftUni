namespace School_Library
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> books = Console.ReadLine().Split('&').ToList();

            string input = Console.ReadLine();

            while (input != "Done")
            {
                string[] commandArgs = input.Split(" | ");

                string command = commandArgs[0];

                if(command.StartsWith("Add"))
                {
                    string book = commandArgs[1];

                    if(!books.Contains(book))
                    {
                        books.Insert(0, book);
                    }
                }
                else if(command.StartsWith("Take"))
                {
                    string book = commandArgs[1];

                    if (books.Contains(book))
                    {
                        int index = books.IndexOf(book);
                        books.RemoveAt(index);
                    }
                }
                else if (command.StartsWith("Swap"))
                {
                    string book = commandArgs[1];
                    string secondBook = commandArgs[2];

                    if(books.Contains(book) && books.Contains(secondBook))
                    {
                        int firstBookIndex = books.IndexOf(book);
                        int secondBookIndex = books.IndexOf(secondBook);

                        string temp = books[firstBookIndex];
                        books[firstBookIndex] = secondBook;
                        books[secondBookIndex] = temp;
                    }
                }
                else if (command.StartsWith("Insert"))
                {
                    string book = commandArgs[1];

                    if (!books.Contains(book))
                    {
                        books.Add(book);
                    }
                }
                else if (command.StartsWith("Check"))
                {
                    int index = int.Parse(commandArgs[1]);

                    if(index >= 0 && index < books.Count)
                    {
                        Console.WriteLine(books[index]);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", books));
        }
    }
}
