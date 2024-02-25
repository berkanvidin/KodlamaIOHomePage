using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using KodlamaIOHomePage.Entities;

namespace KodlamaIOHomePage.Data.Abstract
{
    public interface ICourseDal
    {
        void Add(Courses course);
        void Update(Courses course);
        void Delete(int courseId);
        Courses Get(Expression<Func<Courses, bool>> whichCourse);
        List<Courses> GetAll(Expression<Func<Courses,bool>> whichCourse = null);
    }
}
