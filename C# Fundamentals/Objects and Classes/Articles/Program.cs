namespace Articles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();

            int numberOfArticles = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfArticles; i++)
            {
                string[] articleArgs = Console.ReadLine().Split(", ");

                string title = articleArgs[0];
                string content = articleArgs[1];
                string author = articleArgs[2];

                Article article = new Article(title, content, author);

                articles.Add(article);
            }

            string filter = Console.ReadLine();

            List<Article> sortedArticles = new List<Article>();

            if(filter == "content")
            {
                sortedArticles = articles.OrderBy(x => x.Content).ToList();
            }
            else if(filter == "author")
            {
                sortedArticles = articles.OrderBy(x => x.Author).ToList();
            }
            else if(filter == "title")
            {
                sortedArticles = articles.OrderBy(x => x.Title).ToList();
            }

            foreach (var article in sortedArticles)
            {
                Console.WriteLine(article.ToString());
            }
        }
    }
}
