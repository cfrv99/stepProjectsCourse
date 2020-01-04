using StepCourseProject.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Repository.Abstract
{
    public interface IUserRepo
    {
        List<AppUser> GetAppUsers();
        AppUser GetAppUser(string id);

        void Add(AppUser entity);
        void Delete(AppUser entity);
        void Update(AppUser entity);
    }
}
