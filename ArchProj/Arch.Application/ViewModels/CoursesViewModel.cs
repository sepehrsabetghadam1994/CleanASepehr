using System.Collections.Generic;
using CleanArch.Domain.Models;

namespace CleanArch.Application.ViewModels
{
   public class CoursesViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
    