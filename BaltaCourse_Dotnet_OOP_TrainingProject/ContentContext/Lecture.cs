using BaltaCourse_Dotnet_OOP_TrainingProject.ContentContext.Enums;

namespace BaltaCourse_Dotnet_OOP_TrainingProject.ContentContext
{
    public class Lecture
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}