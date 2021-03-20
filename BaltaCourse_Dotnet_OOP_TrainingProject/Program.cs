using System;
using System.Collections.Generic;
using BaltaCourse_Dotnet_OOP_TrainingProject.ContentContext;

namespace BaltaCourse_Dotnet_OOP_TrainingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();

            articles.Add(new Article(
                title: "Artigo sobre OOP",
                url: "orientacao-objetos"
            ));

            articles.Add(new Article(
                title: "Artigo sobre C#",
                url: "csharp"
            ));

            articles.Add(new Article(
                title: "Artigo sobre .NET",
                url: "dotnet"
            ));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine($"{article.Url}\n");
            }
        }
    }
}
