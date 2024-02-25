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
    public class InstructorManager : IInstructorService
    {
        private IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }
        public void Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
        }

        public void Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
        }

        public void Delete(int instructorId)
        {
            _instructorDal.Delete(instructorId);
        }

        public Instructor Get(int instructorId)
        {
            return _instructorDal.Get(i => i.Id == instructorId);
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll().ToList();
        }
    }
}
