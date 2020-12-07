using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Domain.Intefaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICoursesRepository
    {
        private UnivercityDBContext _db;
        public CourseRepository(UnivercityDBContext db)
        {
            _db = db;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _db.Courses;
        }
    }
}
