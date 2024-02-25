using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodlamaIOHomePage.Entities;

namespace KodlamaIOHomePage.Business.Abstract
{
    public interface ICategoryService
    {
        void Add(Category category);
        void Delete(int categoryId);
        void Update(Category category);
        Category Get(int categoryId);
        List<Category> GetList();

    }
}
