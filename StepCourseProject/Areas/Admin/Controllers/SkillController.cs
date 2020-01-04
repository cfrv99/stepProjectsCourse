using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StepCourseProject.Areas.Admin.Models;
using StepCourseProject.Entites;
using StepCourseProject.Repository.Abstract;

namespace StepCourseProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SkillController : Controller
    {
        private readonly ISkillRepo repo;

        public SkillController(ISkillRepo repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            var skills = repo.GetSkills().Select(i => new SkillsVM
            {
                Id = i.Id,
                SkillName = i.SkillName
            });
            return View(skills);
        }

        public IActionResult Create()
        {
            return View(new SkillCreateVM());
        }

        [HttpPost]
        public IActionResult Create(SkillCreateVM vm)
        {
            if (ModelState.IsValid)
            {
                if (vm != null)
                {
                    Skill s = new Skill();
                    s.SkillName = vm.Name;

                    repo.Add(s);
                    return RedirectToAction("Index");
                }
            }

            return View(vm);

        }

    }
}