using StepCourseProject.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Repository.Abstract
{
    public interface IMessageRepo
    {
        List<Message> GetMessages();
        Message GetMessage(int id);

        void Add(Message entity);
        void Delete(Message entity);
        void Update(Message entity);
    }
}
