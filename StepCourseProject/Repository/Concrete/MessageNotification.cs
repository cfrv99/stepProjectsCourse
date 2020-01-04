using StepCourseProject.Entites;
using StepCourseProject.Entites.Contexts;
using StepCourseProject.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Repository.Concrete
{
    public class MessageNotification : IMessageRepo
    {
        private readonly AppDbContext context;

        public MessageNotification(AppDbContext context)
        {
            this.context = context;
        }
        public void Add(Message entity)
        {
            if (entity != null)
            {
                context.Messages.Add(entity);
                context.SaveChanges();
            }

            throw new Exception("Message ws not found");
        }

        public void Delete(Message entity)
        {
            if (entity != null)
            {
                context.Messages.Add(entity);
                context.SaveChanges();
            }
            throw new Exception("Message was not found");
        }

        public Message GetMessage(int id)
        {
            if (id > 0)
            {
                var message = context.Messages.FirstOrDefault(i=>i.Id==id);
                return message;
            }

            throw new Exception("Message was not found");
        }

        public List<Message> GetMessages()
        {
            return context.Messages.ToList();
        }

        public void Update(Message entity)
        {
            if (entity != null)
            {
                context.Messages.Update(entity);
                context.SaveChanges();
            }
            throw new Exception("Message was not found");
        }
    }
}
