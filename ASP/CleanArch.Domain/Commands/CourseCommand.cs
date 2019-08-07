using CleanArch.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Commands
{
    public class CourseCommand : Command
    {
        public string Name { protected set; get; }
        public string Description { protected set; get; }
        public string ImageUrl { protected set; get; }
        
    }
}
