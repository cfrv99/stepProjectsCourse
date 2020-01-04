using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StepCourseProject.Areas.Admin.Models;
using StepCourseProject.Entites;
using StepCourseProject.Entites.Contexts;
using StepCourseProject.Repository.Abstract;
using StepCourseProject.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService service;
        private readonly ICategoryRepo repo;
        private readonly AppDbContext context;
        private readonly UserManager<AppUser> userManager;

        public CategoryController(ICategoryService service, ICategoryRepo repo, AppDbContext context, UserManager<AppUser> userManager)
        {
            this.service = service;
            this.repo = repo;
            this.context = context;
            this.userManager = userManager;
        }

        public IActionResult All()
        {
            var categories = repo.GetCategories().Select(i => new CategoriesVM
            {
                Id = i.Id,
                Name = i.CategoryName
            });

            return View(categories);
        }

        public IActionResult Create()
        {
            return View(new CategoryCreateVM());
        }

        [HttpPost]
        public IActionResult Create(CategoryCreateVM vm)
        {
            if (ModelState.IsValid)
            {
                if (vm != null)
                {
                    Category c = new Category()
                    {
                        CategoryName = vm.CategoryName
                    };

                    repo.Add(c);
                    return RedirectToAction("All");
                }
            }
            return View(vm);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var category = repo.GetCategory(id);

            repo.Delete(category);
            return RedirectToAction("All");
        }

        public IActionResult Details(int id)
        {
            using (var context = new AppDbContext())
            {
                var category = context.Categories.Include(i => i.Posts).Select(i => new CategoryDetailVM
                {
                    CategoryName = i.CategoryName,
                    Posts = i.Posts.ToList()
                }).FirstOrDefault();
                return View(category);
            }


        }

        public async Task<IActionResult> TestAction()
        {


            var user = await userManager.FindByNameAsync(User.Identity.Name);
            List<Post> postlar = new List<Post>();
            var userSkill = context.UserSkills.Where(i => i.AppUserId == user.Id).ToList();


            //var posts = context.PostSkills.ToList();

            //foreach (var item in userSkill)
            //{
            //    foreach (var post in posts)
            //    {
            //        if (post.SkillId == item.SkillId)
            //        {
            //            var p = context.Posts.FirstOrDefault(i => i.Id == post.PostId);
            //            postlar.Add(p);
            //        }
            //    }
            //}

            HashSet<int> diffids = new HashSet<int>(userSkill.Select(s => s.SkillId));
            var postss = context.Posts.Include(i=>i.Skill).Where(i => diffids.Contains(i.SkillId));

            return View();
        }
    }


}
