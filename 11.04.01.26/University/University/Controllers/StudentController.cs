using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using University.Data;

namespace University.Controllers
{
    public class StudentController : Controller
    {
        private readonly UniversityContext _context;

        public StudentController
            (
                UniversityContext context
            )
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            //leiame kõik student id ja teisendame need StudenIndexViewMOdeliks
            //miks peab kasutama await?
            //kui me kasutame await, siis me ootame kuni päring on lõpetatud
            //ja saame tulemuse, enne kui me jätkame koodi täitmist

            var result = await _context.Students
                .Select(s => new ViewModel.StudentIndexViewModel
                {
                    Id = s.Id,
                    LastName = s.LastName,
                    FirstMidName = s.FirstMidName,
                    EnrollmentDate = s.EnrollmentDate
                    //miks kasutasime ToListAsync()?
                    //Kui me kasutame ToListAsync(); siis me saame tulemuse listina
                }).ToListAsync();

            return View(result);
        }
        public async Task<IActionResult> Details(int? id)
        {
            //kui id on 0 siis tagastab notfound tulemuse
            if (id == null)
            {
                return NotFound();
            }
            //leiame studenti id järgi
            var student = await _context.Students
                .FirstOrDefaultAsync(m => m.Id == id);

            //kui student on 0 siis tagastab notfound tulemuse
            if (student == null)
            {
                return NotFound();
            }

            //kui student on leitud,siis tagastab View(student) tulemsue
            return View(student);
        }
    }
}