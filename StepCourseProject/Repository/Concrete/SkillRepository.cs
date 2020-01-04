using StepCourseProject.Entites;
using StepCourseProject.Entites.Contexts;
using StepCourseProject.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Repository.Concrete
{
    public class SkillRepository : ISkillRepo
    {
        private readonly AppDbContext context;

        public SkillRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Add(Skill entity)
        {
            if (entity != null)
            {
                context.Skills.Add(entity);
                context.SaveChanges();
            }
            else
            throw new Exception("Skill was not founded");
        }

        public void Delete(Skill entity)
        {
            if (entity != null)
            {
                context.Skills.Remove(entity);
                context.SaveChanges();

            }
            throw new Exception("Skill was not found");
        }

        public Skill GetSkill(int id)
        {
            if (id > 0)
            {
                var skill = context.Skills.FirstOrDefault(i=>i.Id==id);
                return skill;
            }

            throw new Exception("Skill was not found");
        }

        public List<Skill> GetSkills()
        {
            return context.Skills.ToList();
        }

        public void Update(Skill entity)
        {
            if (entity != null)
            {
                context.Skills.Update(entity);
                context.SaveChanges();
            }

            throw new Exception("was not found");
        }
    }
}
