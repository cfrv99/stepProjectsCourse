using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Models
{
    public class LoginVM
    {
        [Required(ErrorMessage ="User name must be entered")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password must be entered")]
        [DataType("Password")]
        public string Password { get; set; }
    }
}
