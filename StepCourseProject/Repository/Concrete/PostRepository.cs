using StepCourseProject.Entites;
using StepCourseProject.Entites.Contexts;
using StepCourseProject.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Repository.Concrete
{
    public class PostRepository : IPostRepo
    {
        private readonly AppDbContext context;

        public PostRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Add(Post entity)
        {
            context.Posts.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Post entity)
        {
            if (entity != null)
            {
                context.Posts.Remove(entity);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Post was not found!");
            }
        }

        public Post GetPost(int id)
        {
            if (id > 0)
            {
                var post = context.Posts.FirstOrDefault(i => i.Id == id);
                return post;
            }

            throw new Exception("Post was not found");
        }

        public List<Post> GetPosts()
        {
            return context.Posts.ToList();
        }

        public void Update(Post entity)
        {
            if (entity != null)
            {
                context.Posts.Update(entity);
                context.SaveChanges();
            }
            throw new Exception("Post was not found");
        }
    }
}
