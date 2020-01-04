using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StepCourseProject.Areas.Admin.Models;
using StepCourseProject.Entites;
using StepCourseProject.Entites.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        private readonly AppDbContext context;
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public HomeController(AppDbContext context,
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            this.context = context;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }
        public async Task<IActionResult> Dashboard()
        {

            var usersClients = await userManager.GetUsersInRoleAsync("Client");
            var usersFreelance = await userManager.GetUsersInRoleAsync("Freelancer");
            var allusers = userManager.Users.ToList();
            var uC = new List<AppUser>();
            var uF = new List<AppUser>();
            foreach (var user in usersClients)
            {
                uC.Add(user);
            }
            foreach (var user in usersFreelance)
            {
                uF.Add(user);
            }

            var projects = context.Posts.ToList();
            var data = context.Users.Include(i => i.Posts).Select(i => new DashboardVM
            {
                Clients = uC,
                Freelancers = uF,
                UserCount = allusers.Count(),
                ProjectCount = projects.Count(),
                ClientsCount = uC.Count(),
                FreelanceCount = uF.Count(),
                Users=allusers
            }).FirstOrDefault();

            return View(data);
        }
    }
}
