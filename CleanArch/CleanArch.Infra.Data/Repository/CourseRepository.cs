using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Repository
{
    class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _dBContext;
        public CourseRepository(UniversityDBContext dBContext)
        {
            _dBContext = dBContext;
        }

        public IEnumerable<Course> GetCourses()
        {
            return _dBContext.Courses;
        }
    }
}
