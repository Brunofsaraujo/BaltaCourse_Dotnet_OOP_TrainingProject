using System;
using BaltaCourse_Dotnet_OOP_TrainingProject.SharedContext;

namespace BaltaCourse_Dotnet_OOP_TrainingProject.SubscriptionContext
{
    public class Subscription : Base
    {
        public Plan Plan { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsInactive => EndDate <= DateTime.Now;
    }
}