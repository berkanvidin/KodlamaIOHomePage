using KodlamaIOHomePage.Business.Abstract;
using KodlamaIOHomePage.Business.Concrete;
using KodlamaIOHomePage.Data.Abstract;
using KodlamaIOHomePage.Data.Concrete;
using KodlamaIOHomePage.Entities;

class Program
{
    private static ICategoryService _categoryService;   
    private static ICourseService _courseService;
    private static IInstructorService _instructorService;
    static void Main(string[] args)
    {
        CategoryProcess();
        CourseProcess();
        InstructorProcess();
    }

    private static void InstructorProcess()
    {
        IInstructorDal instructorDal = new DataInstructorDal();
        _instructorService = new InstructorManager(instructorDal);
        AddInstructor();
        UpdateInstructor();
        DeleteInstructor(5);
        GetInstructorById(1);
        GetInstructors();
    }

    private static void GetInstructors()
    {
        Console.WriteLine("--------------------------Instructor List--------------------------");
        var instructorList = _instructorService.GetAll();
        foreach (var instructor in instructorList)
        {
            Console.WriteLine($"Category Id: {instructor.Id},Category Name: {instructor.Name}");
        }
    }

    private static void GetInstructorById(int id)
    {
        var instructors = _instructorService.Get(id);
        Console.WriteLine("-----------Instructor Introduced-----------");
        Console.WriteLine($"Course Id: {instructors.Id}\nCourse Name: {instructors.Name}");
    }

    private static void DeleteInstructor(int id)
    {
        _instructorService.Delete(id);
        Console.WriteLine("Instructor Deleted.");
       
    }

    private static void UpdateInstructor()
    {
        int updatInstructor = 2;
        Instructor instructor = new Instructor
        {
            Id = updatInstructor,
            Name = "Update Ahmet Şerif İzgören"
        };
        Console.WriteLine("Instructor Updated.");
    }

    private static void AddInstructor()
    {
        Console.WriteLine("-----------------------------------------");
        Instructor instructor = new Instructor
        {
            Id = 5,
            Name = "Volkan Alakent"
        };
        Console.WriteLine("Instructor Added.");
    }

    private static void CourseProcess()
    {
        ICourseDal courseDal = new DataCourseDal();
        _courseService = new CourseManager(courseDal);
        AddCourse();
        UpdateCourse();
        DeleteCourse();
        GetCourseById(1);
        GetCourseList();
    }

    private static void GetCourseList()
    {
        Console.WriteLine("-----------------------------------------------------------------Category List-----------------------------------------------------------------");
        var courses = _courseService.GetAll();
        foreach (var course in courses)
        {
            Console.WriteLine($"Course Id: {course.Id}\nCategory Id:{course.CategoryId}\nInstructor Id:{course.InstructorId}\nImage URL: {course.ImageUrl}\nCourse Name: {course.Name}\nCourse Description: {course.Description}");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------");
        }
    }

    private static void GetCourseById(int id)
    {
        var course = _courseService.Get(id);
        Console.WriteLine("-----------Course Introduced-----------");
        Console.WriteLine($"Course Id: {course.Id},\nCourse Name: {course.Name},\nCourse Description: {course.Description}");
        
    }

    private static void DeleteCourse()
    {
        int courseId = 9;
        _courseService.Delete(courseId);
        Console.WriteLine("Course Deleted.");
    }

    private static void UpdateCourse()
    {
        int courseId = 1;
        Courses updateCourses = new Courses
        {
            Id = courseId,
            CategoryId = 1,
            InstructorId = 1,
            Name = "Updated Yazılım Geliştirici Yetiştirme Kampı (JavaScript)",
            ImageUrl = "https://ibb.co/KDM4k8r",
            Description = "1,5 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız."
        };
        Console.WriteLine("Course Updated.");
    }

    private static void AddCourse()
    {
        Console.WriteLine("-----------------------------------------");
        Courses course = new Courses
        {
            Id = 9,CategoryId = 1,InstructorId = 1,ImageUrl = "Uri",Name = "2024 JavaScript Bootcamp",Description = "Bu eğitim 2 - 3 Ay sürecektir."
        };
        Console.WriteLine("Course Added.");
    }

    private static void CategoryProcess()
    {
        ICategoryDal categoryDal = new DataCategoryDal();
        _categoryService = new CategoryManager(categoryDal);
        AddCategory();
        UpdateCategory();
        DeleteCategory();
        GetCategoryById(1);
        ListCategory();
    }

    private static void ListCategory()
    {
        Console.WriteLine("--------------Category List--------------");
        var categories = _categoryService.GetList();
        foreach (var category in categories)
        {
            Console.WriteLine($"Category Id: {category.Id},Category Name: {category.Name}");
        }
    }

    private static void GetCategoryById(int id)
    {
        var category = _categoryService.Get(id);
        Console.WriteLine("-----------Category Introduced-----------");
        Console.WriteLine($"Category Id: {category.Id},Category Name: {category.Name}");
        
    }

    private static void DeleteCategory()
    {
        int categoryId = 3;
        _categoryService.Delete(categoryId);
        Console.WriteLine("Category Deleted.");
    }

    private static void UpdateCategory()
    {
        int categoryId = 1;
        Category updateCategory = new Category
        {
            Id = categoryId,
            Name = "Updated Category Name"
        };
        Console.WriteLine("Category Name Updated.");
    }

    private static void AddCategory()
    {
        Console.WriteLine("-----------------------------------------");
        Category category = new Category
        {
            Id = 3,
            Name = "Mathematics"
        };
        _categoryService.Add(category);
        Console.WriteLine("Category Added.");
    }
}

