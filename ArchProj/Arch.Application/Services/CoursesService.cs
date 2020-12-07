using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Intefaces;

namespace CleanArch.Application.Services
{
    public class CoursesService : ICoursesService
    {
        private ICoursesRepository _courseRepository;
        public CoursesService(ICoursesRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public CoursesViewModel GetCourses()
        {
            return new CoursesViewModel()
            {
                Courses= _courseRepository.GetCourses()

            };
                
        }
    }
}
