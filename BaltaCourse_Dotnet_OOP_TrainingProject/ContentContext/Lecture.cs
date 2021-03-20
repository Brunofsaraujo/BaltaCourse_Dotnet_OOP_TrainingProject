using BaltaCourse_Dotnet_OOP_TrainingProject.ContentContext.Enums;
using BaltaCourse_Dotnet_OOP_TrainingProject.SharedContext;

namespace BaltaCourse_Dotnet_OOP_TrainingProject.ContentContext
{
    public class Lecture : Base
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}