using KodlamaIOHomePage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOHomePage.Business.Abstract
{
    public interface ICourseService
    {
        void Add(Courses course);
        void Update(Courses course);
        void Delete(int courseId);
        Courses Get(int courseId);
        List<Courses> GetAll();
        List<Courses> GetByInstructorId(int instructorId);
        List<Courses> GetByCategoryId(int categoryId);

    }
}
