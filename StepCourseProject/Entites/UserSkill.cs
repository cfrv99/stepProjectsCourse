using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Entites
{
    public class UserSkill
    {

        
        public string AppUserId { get; set; }
        public int SkillId { get; set; }
        [ForeignKey("AppUserId")]
        public AppUser AppUser { get; set; }
        [ForeignKey("SkillId")]
        public Skill Skill { get; set; }


    }
}
