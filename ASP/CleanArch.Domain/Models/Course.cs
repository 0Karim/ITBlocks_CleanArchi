using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Models
{
    public class Course
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string ImageUrl { set; get; }
    }
}
