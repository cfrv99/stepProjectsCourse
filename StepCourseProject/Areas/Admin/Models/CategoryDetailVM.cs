using StepCourseProject.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Areas.Admin.Models
{
    public class CategoryDetailVM
    {
        public string CategoryName { get; set; }
        public List<Post> Posts { get; set; }
    }
}
