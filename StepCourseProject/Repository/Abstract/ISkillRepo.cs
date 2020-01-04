using StepCourseProject.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Repository.Abstract
{
    public interface ISkillRepo
    {
        List<Skill> GetSkills();
        Skill GetSkill(int id);

        void Add(Skill entity);
        void Delete(Skill entity);
        void Update(Skill entity);
    }
}
