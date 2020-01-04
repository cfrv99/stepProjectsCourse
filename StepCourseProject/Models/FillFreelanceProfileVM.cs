using StepCourseProject.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Models
{
    public class FillFreelanceProfileVM
    {
        [Required]
        [UIHint("Fullname")]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        [UIHint("Email Address")]
        public string Email { get; set; }

        [Required]
        [DataType("Number")]
        [UIHint("Age")]
        public int Age { get; set; }

        [Required]
        [DataType("Number")]
        [UIHint("Experience")]
        public int Experience { get; set; }
        [Required]
        [MinLength(100)]
        public string Description { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime BirthDay { get; set; }
        [Required]
        public string City { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        public List<UserSkill> Skills { get; set; }
    }
}
