using System;
using BaltaCourse_Dotnet_OOP_TrainingProject.NotificationContext;

namespace BaltaCourse_Dotnet_OOP_TrainingProject.SharedContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

    }
}