using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Entites.Configurations
{
    public class UserSkillConfiguration : IEntityTypeConfiguration<UserSkill>
    {
        public void Configure(EntityTypeBuilder<UserSkill> builder)
        {
            builder.HasKey(ps => new { ps.AppUserId, ps.SkillId  });


            builder.HasOne(ps => ps.AppUser)
                .WithMany(ps => ps.UserSkills)
                .HasForeignKey(ps => ps.AppUserId);

            builder.HasOne(ps => ps.Skill)
                .WithMany(ps => ps.UserSkills)
                .HasForeignKey(ps => ps.SkillId);

            
        }
    }
}
