using KodlamaIOHomePage.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodlamaIOHomePage.Data.Abstract;
using KodlamaIOHomePage.Entities;

namespace KodlamaIOHomePage.Business.Concrete
{
    public class CourseManager : ICourseService
    {
        private ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        public void Add(Courses course)
        {
            _courseDal.Add(course);
        }

        public void Update(Courses course)
        {
            _courseDal.Update(course);
        }

        public void Delete(int courseId)
        {
            _courseDal.Delete(courseId);
        }

        public Courses Get(int courseId)
        {
            return _courseDal.Get(c => c.Id == courseId);
        }

        public List<Courses> GetAll()
        {
            return _courseDal.GetAll().ToList();
        }

        public List<Courses> GetByInstructorId(int instructorId)
        {
            return _courseDal.GetAll(c => c.InstructorId == instructorId).ToList();
        }

        public List<Courses> GetByCategoryId(int categoryId)
        {
            return _courseDal.GetAll(c => c.CategoryId == categoryId).ToList();
        }
    }
}
