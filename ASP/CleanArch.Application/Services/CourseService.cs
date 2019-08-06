using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {

        //here will call ICourse Repository and inject it to get all courses from our domain
        ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }


        public CoursesViewModel GetAll()
        {
            return new CoursesViewModel
            {
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}
