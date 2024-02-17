using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void AddCourse(Course course)
        {
            _courseDal.Add(course);
        }

        public void DeleteCourse(Course course)
        {
            _courseDal.Delete(course);
        }

        public List<Course> GetAllCourses()
        {
            return _courseDal.GetAll();
        }

        public Course GetCourseByID(int id)
        {
            return _courseDal.GetById(id);
        }

        public void UpdateCourse(Course course)
        {
            _courseDal.Update(course);
        }
    }
}
