using System.Collections.Generic;

namespace BaltaCourse_Dotnet_OOP_TrainingProject.ContentContext
{
    public class Course : Content
    {
        public Course()
        {
            Modules = new List<Module>();
            Lectures = new List<Lecture>();
        }

        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public IList<Lecture> Lectures { get; set; }
    }

    public class Module
    {
        public int Order { get; set; }
        public string Title { get; set; }
    }

    public class Lecture
    {
        public int Order { get; set; }
        public string Title { get; set; }
    }
}