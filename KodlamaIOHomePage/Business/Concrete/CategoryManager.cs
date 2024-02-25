using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodlamaIOHomePage.Business.Abstract;
using KodlamaIOHomePage.Data.Abstract;
using KodlamaIOHomePage.Entities;

namespace KodlamaIOHomePage.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(int categoryId)
        {
            _categoryDal.Delete(categoryId);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }

        public Category Get(int categoryId)
        {
            return _categoryDal.Get(c => c.Id == categoryId);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetAll().ToList();
        }
    }
}
