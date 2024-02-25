using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using KodlamaIOHomePage.Entities;

namespace KodlamaIOHomePage.Data.Abstract
{
    public interface IInstructorDal
    {
        void Add(Instructor instructor);
        void Update(Instructor instructor);
        void Delete(int instructorId);
        Instructor Get(Expression<Func<Instructor, bool>> whichInstructor);
        List<Instructor> GetAll(Expression<Func<Instructor,bool>> whichInstructor = null);
    }
}
