using System;
using System.Collections.Generic;
using System.Linq;
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

            var courseOOP = new Course(
                title: "Fundamentos OOP",
                url: "fundamentos-oop"
            );

            var courseCsharp = new Course(
                title: "Fundamentos C#",
                url: "fundamentos-csharp"
            );

            var courseAspNet = new Course(
                title: "Fundamentos ASP.NET",
                url: "fundamentos-aspnet"
            );

            var courses = new List<Course>();
            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);

            var careerDotnet = new Career(
                title: "Especialista .NET",
                url: "especialista-dotnet"
            );

            var careerItem2 = new CareerItem(
                order: 2,
                title: "Aprenda OOP",
                description: "",
                course: null
            );

            var careerItem = new CareerItem(
                order: 1,
                title: "Comece por aqui",
                description: "",
                course: null
            );

            var careerItem3 = new CareerItem(
                order: 3,
                title: "Aprenda .NET",
                description: "",
                course: null
            );

            var careers = new List<Career>();
            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem);
            careerDotnet.Items.Add(careerItem3);
            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                }
            }
            Console.WriteLine($"\n");
        }
    }
}
