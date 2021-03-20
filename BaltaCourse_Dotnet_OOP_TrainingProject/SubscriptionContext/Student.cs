using BaltaCourse_Dotnet_OOP_TrainingProject.SharedContext;

namespace BaltaCourse_Dotnet_OOP_TrainingProject.SubscriptionContext
{
    public class Student : Base
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
    }
}