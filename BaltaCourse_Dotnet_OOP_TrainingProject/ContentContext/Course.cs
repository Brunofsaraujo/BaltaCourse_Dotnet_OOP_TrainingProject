using System.Collections.Generic;
using BaltaCourse_Dotnet_OOP_TrainingProject.ContentContext.Enums;

namespace BaltaCourse_Dotnet_OOP_TrainingProject.ContentContext
{
    public class Course : Content
    {
        public Course()
        {
            Modules = new List<Module>();
        }

        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}