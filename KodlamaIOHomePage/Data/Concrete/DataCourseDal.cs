using KodlamaIOHomePage.Business.Abstract;
using KodlamaIOHomePage.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using KodlamaIOHomePage.Entities;

namespace KodlamaIOHomePage.Data.Concrete
{
    public class DataCourseDal : ICourseDal
    {
        private static List<Courses> _courses;

        public DataCourseDal()
        {
            _courses = new List<Courses>
            {
                new Courses{Id = 1,CategoryId = 1,InstructorId = 1,ImageUrl = "https://ibb.co/KDM4k8r",Name = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)",Description = "1,5 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız."},
                new Courses{Id = 2,CategoryId = 1,InstructorId = 1,ImageUrl = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://www.filepicker.io/api/file/Zk7d1MdoSJ6cEShVbfd0",Name = "\r\nYazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)",Description = "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız."},
                new Courses{Id = 3,CategoryId = 1,InstructorId = 1,ImageUrl = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://cdn.filestackcontent.com/qUyYtyzXTrOSH2M2ApBh",Name = "(2022) Yazılım Geliştirici Yetiştirme Kampı - JAVA",Description = "Java Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız."},
                new Courses{Id = 4,CategoryId = 1,InstructorId = 1,ImageUrl = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://cdn.filestackcontent.com/We86Zc3xQy6FUqhyBJJc",Name = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)",Description = "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız."},
                new Courses{Id = 5,CategoryId = 1,InstructorId = 1,ImageUrl = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://www.filepicker.io/api/file/qi4s19xSKCmtaaRUqUFI",Name = "Yazılım Geliştirici Yetiştirme Kampı (JAVA + REACT)",Description = "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız."},
                new Courses{Id = 6,CategoryId = 1,InstructorId = 1,ImageUrl = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://cdn.filestackcontent.com/ujZYJ3lwSOihtnbP9LsG",Name = "Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)",Description = "Senior Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız."},
                new Courses{Id = 7,CategoryId = 1,InstructorId = 1,ImageUrl = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://www.filepicker.io/api/file/BBLmG3XFTtm8XBTrzg4v",Name = "Programlamaya Giriş için Temel Kurs",Description = "PYTHON, JAVA, C# gibi tüm programlama dilleri için temel programlama mantığını anlaşılır örneklerle öğrenin."},
                new Courses{Id = 8,CategoryId = 1,InstructorId = 3,ImageUrl = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://cdn.filestackcontent.com/3nqAGqHARL6uEULbaQvr",Name = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium",Description = "Python & Selenium Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız."},
                new Courses{Id = 9,CategoryId = 1,InstructorId = 3,ImageUrl = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://cdn.filestackcontent.com/3nqAGqHARL6uEULbaQvr",Name = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium",Description = "Python & Selenium Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız."}
            };
        }
        public void Add(Courses course)
        {
            _courses.Add(course);
        }

        public void Update(Courses course)
        {
            Courses courseUpdate = _courses.FirstOrDefault(c => c.Id == course.Id);
            if (courseUpdate != null)
            {
                courseUpdate.Name = course.Name;
                courseUpdate.Description = course.Description;
                courseUpdate.CategoryId = course.CategoryId;
                courseUpdate.Description = course.Description;
                courseUpdate.ImageUrl = course.ImageUrl;
            }
            else
            {
                throw new Exception("Course not Found");
            }
        }

        public void Delete(int courseId)
        {
            Courses courseDelete = _courses.FirstOrDefault(c=> c.Id == courseId);
            if (courseDelete != null)
            {
                _courses.Remove(courseDelete);
            }
        }

        public Courses Get(Expression<Func<Courses, bool>> whichCourse)
        {
            return _courses.SingleOrDefault(whichCourse.Compile());
        }

        public List<Courses> GetAll(Expression<Func<Courses, bool>> whichCourse = null)
        {
            if (whichCourse == null)
            {
                return _courses;
            }
            else
            {
                return _courses.Where(whichCourse.Compile()).ToList();
            }
            
        }
    }
}
