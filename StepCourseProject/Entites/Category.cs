using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Entites
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public DateTime? Date { get; set; }

        public List<Post> Posts { get; set; }



        public Category()
        {
            Posts = new List<Post>();
            Date = DateTime.Now;
        }
    }
}
