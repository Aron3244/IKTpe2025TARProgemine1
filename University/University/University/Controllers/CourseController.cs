using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using University.Data;
using University.ViewModel;

namespace University.Controllers
{
    public class CourseController : Controller
    {
        //on vaja kutsuda välja University constructor
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
            var result = await _context.Courses
                .Include(c => c.DeapartmenId)
                .AsNoTracking()
                .ToArrayAsync();

            return View(result);
        }
    }
}
