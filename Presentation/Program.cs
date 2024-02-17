using Business.Abstracts;
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;

ICategoryService _categoryService = new CategoryManager(new CategoryRepository());
ICourseService _courseService = new CourseManager(new CourseRepository());
IInstructorService _instructorService = new InstructorManager(new InstructorRepository());


//Category CRUD
Category category4 = new Category();
category4.Id = 3;
category4.CategoryName = "Mobil";

Category category5 = new Category();
category5.Id = 4;
category5.CategoryName = "Veri Tabani";

_categoryService.AddCategory(category4);
_categoryService.AddCategory(category5);

//_categoryService.DeleteCategory(category4);

category4.CategoryName = "Siber";
_categoryService.UpdateCategory(category4);

_categoryService.DeleteCategory(_categoryService.GetCategoryByID(2));

foreach (var category in _categoryService.GetAllCategories())
{
    Console.WriteLine(category.Id + " : " + category.CategoryName);
}


//Course CRUD
Course course3 = new Course();
course3.Id = 3;
course3.CourseName = "SQL";
course3.Description = "Temel seviye MSSQL";
course3.Price = 300;
course3.CategoryId = 4;
course3.InstructorId = 2;

Course course4 = new Course();
course4.Id = 4;
course4.CourseName = "Network";
course4.Description = "Temel seviye Network";
course4.Price = 400;
course4.CategoryId = 3;
course4.InstructorId = 1;

Course course5 = new Course();
course5.Id = 5;
course5.CourseName = "deneme";
course5.Description = "test deneme";
course5.Price = 500;
course5.CategoryId = 2;
course5.InstructorId = 2;

_courseService.AddCourse(course3);
_courseService.AddCourse(course4);
_courseService.AddCourse(course5);

course5.CategoryId = 1;
_courseService.UpdateCourse(course5);

_courseService.DeleteCourse(_courseService.GetCourseByID(5));

foreach (var course in _courseService.GetAllCourses())
{
    Console.WriteLine(course.CourseName + " " + course.CategoryId);
}


// Instructor CRUD

Instructor instructor3 = new Instructor();
instructor3.Id = 3;
instructor3.FirstName = "Engin";
instructor3.LastName = "Demiroğ";
instructor3.Email = "engindemirog@gmail.com";

Instructor instructor4 = new Instructor();
instructor4.Id = 4;
instructor4.FirstName = "Ali";
instructor4.LastName = "Veli";
instructor4.Email = "aliveli@gmail.com";

_instructorService.AddInstructor(instructor3);
_instructorService.AddInstructor(instructor4);

instructor4.Email = "deneme@gmail.com";
_instructorService.UpdateInstructor(instructor4);

Console.WriteLine(instructor4.Email);

_instructorService.DeleteInstructor(_instructorService.GetInstructorByID(4));

foreach (var instructor in _instructorService.GetAllInstructors())
{
    Console.WriteLine(instructor.FirstName + " " + instructor.LastName);
}
