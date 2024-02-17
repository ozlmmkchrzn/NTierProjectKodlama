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
    public class InstructorManager : IInstructorService
    {
        IInstructorDal _instructor;

        public InstructorManager(IInstructorDal instructor)
        {
            _instructor = instructor;
        }

        public void AddInstructor(Instructor instructor)
        {
            _instructor.Add(instructor);
        }

        public void DeleteInstructor(Instructor instructor)
        {
            _instructor.Delete(instructor);
        }

        public List<Instructor> GetAllInstructors()
        {
            return _instructor.GetAll();
        }

        public Instructor GetInstructorByID(int id)
        {
            return _instructor.GetById(id);
        }

        public void UpdateInstructor(Instructor instructor)
        {
            _instructor.Update(instructor);
        }
    }
}
