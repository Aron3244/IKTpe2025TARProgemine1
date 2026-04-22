using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using University.Data;
using University.Models;
using University.ViewModel;

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
            //leiame kõik student'id ja teisendame need StudentIndexViewModel'iks
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
                    //miks kasutame ToListAsync()?
                    //kui me kasutame ToListAsync(), siis me saame tulemuse listina
                }).ToListAsync();

            return View(result);
        }

        public async Task<IActionResult> Details(int? id)
        {
            //kui id on null, siis tagastame NotFound() tulemuse
            if (id == null)
            {
                return NotFound();
            }

            //leiame student'i id järgi
            var student = await _context.Students
                //Include lubab objekti kasutada objekti sees
                .Include(s => s.Enrollments)
                //kui tahad uuestu objecti kasutada objekti sees, siis kasutad ThenInclude
                .ThenInclude(e => e.Course)
                //See lülitab välja andmete muudatuste jälgimise, et muuta päringud kiiremaks ja säästa mälu.
                .AsNoTracking()
                //tagastab esimese elemend, mis on tingimuses välja toodud
                .FirstOrDefaultAsync(m => m.Id == id);
            var vm = new StudentDetailsViewModel
            {
                Id = student.Id,
                LastName = student.LastName,
                FirstMidName = student.FirstMidName,
                EnrollmentDate = student.EnrollmentDate,
                //kui object on objekti sees, siis tuleb teha niimoodi
                //Miks kasutasime ?? - vaikia väärtusE ANNAB EHK DEFUALT väärtuse  ,kui muutuja on tühi(NULL)
                //või´mitte drfineeritud.Annab enne vasakpoolse väärtsw, kui seé ei ole null, kui on null siis annab parempoolse väärtuse.
                EnrollmentsVm = (student.Enrollments ?? Enumerable.Empty<Enrollment>())
                   .Select(x => new EnrollmentViewModel
                   {
                        CourseId = x.CourseId,
                        Grade = x.Grade,
                        CourseVm = new CourseViewModel
                        //1 õpilane võib mitu kursust olla läbinud ja selle tulemuseks tuleb 
                        {
                            CourseId = x.Course?.CourseId ?? 0,
                            Title = x.Course?.Title,
                            Credits = x.Course?.Credits ?? 0
                        }
                   }).ToArray()


            };

            //kui student on null, siis tagastame NotFound() tulemuse
            if (student == null)
            {
                return NotFound();
            }

            //kui student on leitud, siis tagastame View(student) tulemuse
            return View(vm);
        }

        //Get: Student/Create
        //see meetod tagastab vaate, kus saab luua uue student-i
        public IActionResult Create()
        {
            return View();
        }
        //Post: Student/Create
        //see meetod salvestab uue student-i andmebaasi
        [HttpPost]
        //see meetod on kaitstud CSRF rünnakute eest
        //see meetod on asünkroolne, mus töhendab, et see meetod ei saa olla samaaegselt mitu korda käivitatud
        public async Task<IActionResult> Create(StudentCreateViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var student = new Models.Student
                {
                    LastName = vm.LastName,
                    FirstMidName = vm.FirstMidName,
                    EnrollmentDate = vm.EnrollmentDate
                };
                //lisame student-i andmebaasi ja salvestame muudatused

                _context.Add(student);
                //miks kasutamae await
                //kui me kasutame await, siis me ootame kuni salvestamine on lõpetatuyd
                await _context.SaveChangesAsync();
                //pärast salvestamist suuname kasutaja Index vaatesse
                return RedirectToAction(nameof(Index));
            }

            return View(vm);
        }
    }
}
