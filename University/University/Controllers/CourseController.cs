using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using University.Data;
using University.Models;
using University.ViewModel;
using University.ViewModel.CoursesVM;

namespace University.Controllers
{
    public class CourseController : Controller
    {
        //on vaja kututada välja Univercity constructor 
        private readonly UniversityContext _context;
        public CourseController
         (
             UniversityContext context
         )

        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var course = _context.Courses
                .Include(c => c.Departments)
                .Select(c => new CourseIndexViewModel
                {
                    CourseId = c.CourseId,
                    Title = c.Title,
                    Credits = c.Credits,
                    DepartmentId = c.DepartmentId,
                    Department = new CourseDepartmentIndexViewModel
                    {
                        DepartmentName = c.Departments.Name
                    }
                 });

            return View(course);

        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var course = await _context.Courses
                .FirstOrDefaultAsync(m => m.CourseId == id);

            if (course == null)
            {
                return NotFound();
            }

            var vm = new CourseUpdateViewModel
            {
                CourseId = course.CourseId,
                Title = course.Title,
                Credits = course.Credits,
                DepartmentId = course.DepartmentId
            };

            return View(vm);
        }

        [HttpPost]
  
        public async Task<IActionResult> Update(CourseUpdateViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var course = new Models.Course
                {
                    CourseId = vm.CourseId,
                    Title = vm.Title,
                    Credits = vm.Credits,
                    DepartmentId = vm.DepartmentId
                };

                var courseUpdateId = course.CourseId;

                _context.Update(course);

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Update), new { id = courseUpdateId });
            }

            return View(vm);
        }
    }
}
