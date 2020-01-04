using StepCourseProject.Entites;
using StepCourseProject.Entites.Contexts;
using StepCourseProject.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Repository.Concrete
{
    public class CategoryRepository : ICategoryRepo
    {

        AppDbContext context;

        public CategoryRepository(AppDbContext context)
        {
            this.context = context;
        }
        public void Add(Category entity)
        {

            context.Categories.Add(entity);
            context.SaveChanges();


        }

        public void Delete(Category entity)
        {
            if (entity != null)
            {
                context.Categories.Remove(entity);
                context.SaveChanges();
            }
            else
            {

                throw new Exception("Category was not found");
            }
        }

        public List<Category> GetCategories()
        {
            return context.Categories.ToList();
        }

        public Category GetCategory(int id)
        {
            if (id > 0)
            {
                var category = context.Categories.FirstOrDefault(i => i.Id == id);
                return category;
            }
            throw new Exception("Category is not exist");
        }

        public void Update(Category entity)
        {
            if (entity != null)
            {
                context.Categories.Update(entity);
                context.SaveChanges();
            }
            throw new Exception("Category was not found");
        }
    }
}
