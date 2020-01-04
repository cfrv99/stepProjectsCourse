using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Entites
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            UserSkills = new List<UserSkill>();
            Posts = new List<Post>();
            Bids = new List<Bid>();
            Notifications = new List<Notification>();
        }

        public string FullName { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public int Experience { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime BirthDay { get; set; }
        public int Rating { get; set; }
        public string ImageUrl { get; set; }
        public List<UserSkill> UserSkills { get; set; }
        public List<Post> Posts { get; set; }
        public List<Bid> Bids { get; set; }
        public List<Notification> Notifications { get; set; }


    }
}
