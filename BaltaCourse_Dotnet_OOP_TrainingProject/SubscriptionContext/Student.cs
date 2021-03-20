using System.Collections.Generic;
using System.Linq;
using BaltaCourse_Dotnet_OOP_TrainingProject.NotificationContext;
using BaltaCourse_Dotnet_OOP_TrainingProject.SharedContext;

namespace BaltaCourse_Dotnet_OOP_TrainingProject.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
        public IList<Subscription> Subscriptions { get; set; }
        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);

        public void CreateSubscription(Subscription subscription)
        {
            if (IsPremium)
                AddNotification(new Notification(
                    "Premium", "O aluno já possui assinatura ativa"));

            Subscriptions.Add(subscription);
        }
    }
}