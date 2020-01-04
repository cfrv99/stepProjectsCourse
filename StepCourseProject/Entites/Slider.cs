using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Entites
{
    public class Slider
    {
        public int Id { get; set; }
        public string SliderName { get; set; }
        public List<ImageSlider> ImageSliders { get; set; }
        public Slider()
        {
            ImageSliders = new List<ImageSlider>();
        }
    }
}
