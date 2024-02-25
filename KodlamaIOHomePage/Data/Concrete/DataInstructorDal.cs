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
    public class DataInstructorDal : IInstructorDal
    {
        private static List<Instructor> _instructors;

        public DataInstructorDal()
        {
            _instructors = new List<Instructor>
            {
                new Instructor { Id = 1, Name = "Engin Demiroğ" },
                new Instructor { Id = 2, Name = "Ahmet Şerif İzgören" },
                new Instructor { Id = 3,Name = "Halil Enes Kalaycı"},
                new Instructor { Id = 4,Name = "Murat Yücedağ"}

            };
        }

        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Update(Instructor instructor)
        {
            Instructor instructorUpdate = _instructors.FirstOrDefault(i => i.Id == instructor.Id);
            if (instructorUpdate != null)
            {
                instructorUpdate.Name = instructor.Name;
            }
        }

        public void Delete(int instructorId)
        {
            Instructor instructorDelete = _instructors.FirstOrDefault(i => i.Id == instructorId);
            if (instructorDelete != null)
            {
                _instructors.Remove(instructorDelete);
            }
        }

        public Instructor Get(Expression<Func<Instructor, bool>> whichInstructor)
        {
            return _instructors.SingleOrDefault(whichInstructor.Compile());
        }

        public List<Instructor> GetAll(Expression<Func<Instructor, bool>> whichInstructor = null)
        {
            if (whichInstructor == null)
            {
                return _instructors;
            }
            else
            {
                return _instructors.Where(whichInstructor.Compile()).ToList();
            }
        }
    }
}
