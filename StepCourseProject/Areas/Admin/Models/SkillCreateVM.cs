using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Areas.Admin.Models
{
    public class SkillCreateVM
    {
        [Required]
        [MaxLength(10)]
        public string Name { get; set; }

    }
}
