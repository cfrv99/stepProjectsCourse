using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Entites
{
    public class Skill
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
        public List<Post> Posts { get; set; }
        public List<UserSkill> UserSkills { get; set; }
        public Skill()
        {
           // PostSkills = new List<PostSkill>();
            UserSkills = new List<UserSkill>();
        }

    }
}
