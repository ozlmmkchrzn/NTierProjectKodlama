using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class InstructorRepository : IInstructorDal
    {
        public List<Instructor> instructors;

        public InstructorRepository()
        {
            Instructor instructor1 = new Instructor();
            instructor1.Id = 1;
            instructor1.FirstName = "Özlem";
            instructor1.LastName = "KOCAHARZEN";
            instructor1.Email = "ozlem@gmail.com";

            Instructor instructor2 = new Instructor();
            instructor1.Id = 2;
            instructor1.FirstName = "Atlas";
            instructor1.LastName = "Melek";
            instructor1.Email = "atlasmelek@gmail.com";

            instructors = new List<Instructor>() {instructor1, instructor2};
        }

        public void Add(Instructor p)
        {
            instructors.Add(p);
        }

        public void Delete(Instructor p)
        {
            instructors.Remove(p);
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public Instructor GetById(int id)
        {
            return instructors.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Instructor p)
        {
            var data = instructors.FirstOrDefault(x => x.Id == p.Id);
            if(data != null)
            {
                data = p;
            }
        }
    }
}
