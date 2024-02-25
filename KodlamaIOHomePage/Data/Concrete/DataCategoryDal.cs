using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using KodlamaIOHomePage.Data.Abstract;
using KodlamaIOHomePage.Entities;

namespace KodlamaIOHomePage.Data.Concrete
{
    public class DataCategoryDal : ICategoryDal
    {
        private static List<Category> _categories;
        public DataCategoryDal()
        {
            _categories = new List<Category>
            {
                new Category{Id = 1,Name = "Programming"},
                new Category{Id = 2,Name = "Communication"},
                new Category{Id = 3,Name = "Physics"}
            };
        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Update(Category category)
        {
            Category categoryUpdate = _categories.FirstOrDefault(c => c.Id == category.Id);
            if (categoryUpdate!=null)
            {
                categoryUpdate.Name= category.Name;
            }
        }

        public void Delete(int categoryId)
        {
            Category categoryDelete = _categories.FirstOrDefault(c => c.Id == categoryId);
            if (categoryDelete != null)
            {
                _categories.Remove(categoryDelete);
            }
            
        }

        public Category Get(Expression<Func<Category, bool>> whichCategory)
        {
            if (whichCategory == null)
            {
                throw new ArgumentNullException(nameof(whichCategory), "Filtre Boş Olamaz.");
            }
            else
            {
                return _categories.SingleOrDefault(whichCategory.Compile());
            }
            
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> whichCategory = null)
        {
            if (whichCategory == null)
            {
                return _categories;
            }
            else
            {
                return _categories.Where(whichCategory.Compile()).ToList();
            }
            
        }
    }
}
