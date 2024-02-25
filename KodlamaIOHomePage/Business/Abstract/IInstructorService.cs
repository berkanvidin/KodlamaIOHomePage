using KodlamaIOHomePage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOHomePage.Business.Abstract
{
    public interface IInstructorService
    {
        void Add(Instructor instructor);
        void Update(Instructor instructor);
        void Delete(int instructorId);
        Instructor Get(int instructorId);
        List<Instructor> GetAll();
    }
}
