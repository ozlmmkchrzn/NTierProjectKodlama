using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IGenericDal<T> where T : class
    {
        void Add(T p);
        void Delete(T p);
        void Update(T p);
        List<T> GetAll(); //All 

        T GetById(int id); //Filter
    }
}
