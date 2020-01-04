using StepCourseProject.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Repository.Abstract
{
    public interface ISliderRepo
    {
        List<Slider> GetSliders();
        Slider GetSlider(int id);

        void Add(Slider entity);
        void Delete(Slider entity);
        void Update(Slider entity);
    }
}
