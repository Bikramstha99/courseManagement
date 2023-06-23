using CourseManagement.Data;
using CourseManagement.Models;
using CourseManagement.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CourseManagement.Controllers
{
    public class CoursesController : Controller
    {
        private readonly CourseDb coursedb;

        public CoursesController(CourseDb coursedb)
        {
            this.coursedb = coursedb;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var course = coursedb.Courses.ToList();
            return View(course);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(AddCourse addcourse)
        {
            var course = new Course()
            {
                Id = Guid.NewGuid(),
                Name = addcourse.Name,
                Category = addcourse.Category,
                Cost = addcourse.Cost,
            };
            coursedb.Courses.Add(course);
            coursedb.SaveChanges();
            return RedirectToAction("Index");   
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var course = coursedb.Courses.FirstOrDefault(c => c.Id == id);
            if (course != null)
            {
                var viewmodel = new UpdateCourse()
                {
                    Id = course.Id,
                    Name = course.Name,
                    Category = course.Category,
                    Cost = course.Cost,
                };
                return View(viewmodel);

            }
            return RedirectToAction("Index");

        }
    }
}
