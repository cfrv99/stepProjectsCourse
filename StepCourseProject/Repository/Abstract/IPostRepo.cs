using StepCourseProject.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Repository.Abstract
{
    public interface IPostRepo
    {
        List<Post> GetPosts();
        Post GetPost(int id);

        void Add(Post entity);
        void Delete(Post entity);
        void Update(Post entity);
    }
}
