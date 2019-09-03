using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _dBContext;
        public CourseRepository(UniversityDBContext dBContext)
        {
            _dBContext = dBContext;
        }

        public void Add(Course course)
        {
            _dBContext.Courses.Add(course);
            _dBContext.SaveChanges();
        }

        public IEnumerable<Course> GetCourses()
        {
            return _dBContext.Courses;
        }
    }
}
