using System;
using BaltaCourse_Dotnet_OOP_TrainingProject.NotificationContext;

namespace BaltaCourse_Dotnet_OOP_TrainingProject.ContentContext
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