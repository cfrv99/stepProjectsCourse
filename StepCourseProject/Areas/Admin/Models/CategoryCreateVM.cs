using System.ComponentModel.DataAnnotations;

namespace StepCourseProject.Areas.Admin.Models
{
    public class CategoryCreateVM
    {
        [Required]
        [MaxLength(25)]
        public string CategoryName { get; set; }
    }
}
