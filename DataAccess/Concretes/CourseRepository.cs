using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class CourseRepository : ICourseDal
    {
        public List<Course> courses;

        public CourseRepository()
        {
            Course course1 = new Course();
            course1.Id = 1;
            course1.CourseName = "Java";
            course1.Description = "Java Başlangıç Seviye";
            course1.Price = 200;
            course1.CategoryId = 1;
            course1.InstructorId = 1;

            Course course2 = new Course();
            course2.Id = 2;
            course2.CourseName = "JavaScript";
            course2.Description = "JavaScript Başlangıç Seviye";
            course2.Price = 100;
            course2.CategoryId = 2;
            course2.InstructorId = 2;

            courses = new List<Course>() {course1, course2};
        }

        public void Add(Course p)
        {
            courses.Add(p);
        }

        public void Delete(Course p)
        {
            courses.Remove(p);
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public Course GetById(int id)
        {
            return courses.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Course p)
        {
            var data = courses.FirstOrDefault(x => x.Id == p.Id);
            if (data != null)
            {
                data = p;
            }
        }
    }
}
