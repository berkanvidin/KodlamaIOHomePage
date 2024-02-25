using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using KodlamaIOHomePage.Entities;

namespace KodlamaIOHomePage.Data.Abstract
{
    public interface ICategoryDal
    {
        void Add(Category category);
        void Update(Category category);
        void Delete(int categoryId);
        Category Get(Expression<Func<Category,bool>> whichCategory);
        List<Category> GetAll(Expression<Func<Category,bool>> whichCategory = null);

    }
}
