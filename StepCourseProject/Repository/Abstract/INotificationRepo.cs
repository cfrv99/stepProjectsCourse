using StepCourseProject.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Repository.Abstract
{
    public interface INotificationRepo
    {
        List<Notification> GetNotifications();
        Notification GetNotification(int id);

        void Add(Notification entity);
        void Delete(Notification entity);
        void Update(Notification entity);  
    }
}
