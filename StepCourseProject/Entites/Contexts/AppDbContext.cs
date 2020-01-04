using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StepCourseProject.Entites.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Entites.Contexts
{
    public class AppDbContext : IdentityDbContext<AppUser,IdentityRole,string>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {
        }

        public AppDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.ApplyConfiguration(new PostSkillConfiguration());
            builder.ApplyConfiguration(new UserSkillConfiguration());
            base.OnModelCreating(builder);
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Skill> Skills { get; set; }
        //public DbSet<PostSkill> PostSkills { get; set; }
        public DbSet<UserSkill> UserSkills { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<ImageSlider> ImageSliders { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
