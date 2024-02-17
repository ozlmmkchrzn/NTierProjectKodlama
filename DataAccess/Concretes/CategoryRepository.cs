using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class CategoryRepository : ICategoryDal
    {
        public List<Category> categories;

        public CategoryRepository()
        {
            Category category1 = new Category();
            category1.Id = 1;
            category1.CategoryName = "Back-End";

            Category category2 = new Category();
            category2.Id = 2;
            category2.CategoryName = "Front-End";

            categories = new List<Category>() { category1, category2 };
        }

        public void Add(Category p)
        {
            categories.Add(p);
        }

        public void Delete(Category p)
        {
            categories.Remove(p);
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public Category GetById(int id)
        {
            return categories.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Category p)
        {
            var data = categories.FirstOrDefault(x => x.Id == p.Id);
            if (data != null)
            {
                data = p;
            }
        }
    }
}
