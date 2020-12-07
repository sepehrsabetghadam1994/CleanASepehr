using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Domain.Models;

namespace CleanArch.Domain.Intefaces
{
   public interface ICoursesRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
