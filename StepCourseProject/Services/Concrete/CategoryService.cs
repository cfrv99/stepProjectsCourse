using StepCourseProject.Entites.Contexts;
using StepCourseProject.Repository.Abstract;
using StepCourseProject.Repository.Concrete;
using StepCourseProject.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Services.Concrete
{
    public class CategoryService : CategoryRepository,ICategoryService
    {
        private readonly AppDbContext context;

        public CategoryService(AppDbContext context) : base(context)
        {
            this.context = context;
        }


    }
}
