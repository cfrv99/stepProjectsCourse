using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StepCourseProject.Entites;
using StepCourseProject.Entites.Contexts;
using StepCourseProject.Models;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly AppDbContext context;

        public AccountController(UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            RoleManager<IdentityRole> roleManager,
            AppDbContext context)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            this.context = context;
        }

        public async Task<IActionResult> Test()
        {
            var user = await userManager.FindByNameAsync(User.Identity.Name);
            var roles = await userManager.GetRolesAsync(user);
            return View(roles);
        }

        public IActionResult Register()
        {
            return View(new RegisterVM());
        }

        [HttpGet]
        public IActionResult Role()
        {
            return View(new RoleVM());
        }
        [HttpPost]
        public async Task<IActionResult> Role(RoleVM vm)
        {
            if (ModelState.IsValid)
            {
                var role = await roleManager.FindByNameAsync(vm.Name);
                if (role == null)
                {
                    IdentityRole r = new IdentityRole();
                    r.Name = vm.Name;
                    var result = await roleManager.CreateAsync(r);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM vm, string selectedRole)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    UserName = vm.UserName,
                    Email = vm.Email,
                    FullName = vm.FirstNameLastName
                };
                var userExist = await userManager.FindByNameAsync(vm.UserName);

                var result = await userManager.CreateAsync(user, vm.Password);
                if (result.Succeeded)
                {
                    //var role = await roleManager.FindByNameAsync("Admin");
                    //await userManager.AddToRoleAsync(user, role.Name);

                    await signInManager.SignInAsync(user, false);
                    var role = await roleManager.FindByNameAsync(selectedRole);
                    if (role == null)
                    {
                        throw new Exception();
                    }
                    await userManager.AddToRoleAsync(user, selectedRole);
                    if (selectedRole == "Freelancer")
                    {
                        return Redirect("/Account/FillProfile");

                    }
                    else
                    {
                        return Redirect("/");
                    }
                }
            }
            else
            {
                ModelState.AddModelError("Register", "Register is faild");
            }
            return View(vm);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginVM());
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM vm)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByNameAsync(vm.UserName);
                if (user != null)
                {
                    await signInManager.SignOutAsync();
                    var result = await signInManager.PasswordSignInAsync(user, vm.Password, false, false);
                    if (result.Succeeded)
                    {

                        var roles = await userManager.GetRolesAsync(user);
                        if (roles.Contains("Admin"))
                        {
                            return Redirect("/Admin/Category/All");
                        }

                        else { return Redirect("/"); }

                    }
                    ModelState.AddModelError("", "Login or Passwrod is incorrect");
                }
            }
            else
            {
                ModelState.AddModelError("Login", "Login is failed");
            }

            return View(vm);
        }

        public async Task<IActionResult> Logout()
        {
            if (User.Identity.IsAuthenticated)
            {
                await signInManager.SignOutAsync();
            }
            return RedirectToAction("Login");
        }
        //[Authorize(Roles = "Freelancer")]
        public async Task<IActionResult> FillProfile()
        {

            var user = await userManager.FindByNameAsync(User.Identity.Name);
            if (!await userManager.IsInRoleAsync(user, "Freelancer"))
            {
                return BadRequest();
            }
            ViewBag.UserName = User.Identity.Name;
            ViewBag.Email = user.Email;
            ViewBag.Skills = new MultiSelectList(context.Skills, "Id", "SkillName");
            FillFreelanceProfileVM model = new FillFreelanceProfileVM()
            {
                Age = user.Age,
                BirthDay = user.BirthDay,
                Experience = user.Experience,
                ImageUrl = user.ImageUrl,
                Description = user.Description,
                PhoneNumber = user.PhoneNumber

            };
            var selectedItems = context.UserSkills.Where(i => i.AppUserId == user.Id).Select(i => i.SkillId);
            ViewBag.Skills = new MultiSelectList(context.Skills, "Id", "SkillName", selectedItems);

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> FillProfile(FillFreelanceProfileVM vm, int[] skillIds, IFormFile file)
        {
            if (ModelState.IsValid)
            {

                if (file != null)
                {
                    var user = await userManager.FindByNameAsync(User.Identity.Name);
                    var filename = $"{Guid.NewGuid().ToString()}{file.FileName}";
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", filename);

                    using (var fs = new FileStream(path, FileMode.OpenOrCreate))
                    {
                        await file.CopyToAsync(fs);
                    }
                    vm.ImageUrl = filename;
                    user.FullName = vm.FullName;
                    user.BirthDay = vm.BirthDay;
                    user.Experience = vm.Experience;
                    user.PhoneNumber = vm.PhoneNumber;
                    user.Description = vm.Description;
                    user.City = vm.City;
                    user.Age = vm.Age;
                    user.ImageUrl = vm.ImageUrl;

                    context.UserSkills.UpdateRange(skillIds.Select(i => new UserSkill { SkillId = i, AppUserId = user.Id }));
                    await context.SaveChangesAsync();
                    var result = await userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        TempData["OK"] = "Profile sucsessfully filled!!!";
                        return Redirect("/");
                    }
                }
            }

            return View(vm);
        }

        public IActionResult Profile(string userId)
        {


            return View();
        }
    }


}
