using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {

        //here will call ICourse Repository and inject it to get all courses from our domain
        private readonly ICourseRepository _courseRepository;

        //here will call bus 
        private readonly IMediatorHandler _bus;

        public CourseService(ICourseRepository courseRepository , IMediatorHandler bus)
        {
            _courseRepository = courseRepository;
            _bus = bus;
        }

        public void Create(CoursesViewModel coursesViewModel)
        {
            var createCourseCommand = new CreateCourseCommand(
                    coursesViewModel.Name , coursesViewModel.Description , coursesViewModel.imageUrl
                );

            _bus.SendCommand(createCourseCommand);

        }

        public CoursesViewModel GetCourses()
        {
            return new CoursesViewModel
            {
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}
