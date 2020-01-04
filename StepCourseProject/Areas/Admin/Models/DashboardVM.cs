using StepCourseProject.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Areas.Admin.Models
{
    public class DashboardVM
    {
        public List<AppUser> Users { get; set; }
        public int UserCount { get; set; }
        public int ProjectCount { get; set; }
        public int ClientsCount { get; set; }
        public int FreelanceCount { get; set; }

        public List<AppUser> Clients { get; set; }
        public List<AppUser> Freelancers { get; set; }

    }
}
