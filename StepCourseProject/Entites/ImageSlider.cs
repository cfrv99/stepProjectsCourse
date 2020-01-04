using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Entites
{
    public class ImageSlider
    {
        public int Id { get; set; }
        public string ImagTitle { get; set; }
        public string ImageUrl { get; set; }
        public int SliderId { get; set; }
        public Slider Slider { get; set; }

    }
}
