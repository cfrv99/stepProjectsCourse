using StepCourseProject.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Repository.Abstract
{
    public interface ICategoryRepo
    {
        List<Category> GetCategories();
        Category GetCategory(int id);

        void Add(Category entity);
        void Delete(Category entity);
        void Update(Category entity); 
    }
}
