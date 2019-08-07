using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.ViewModels
{
    public class CoursesViewModel
    {
        public string Name { set; get; }
        public string Description { set; get; }
        public string imageUrl { set; get; }
        public IEnumerable<Course> Courses { set; get; }
    }
}
