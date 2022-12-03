using Microsoft.AspNetCore.Mvc;
using StudentsNotebook.Models;
using System.Diagnostics;

namespace StudentsNotebook.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _datacontext;
        //Kurs sam = new Kurs(2,"","","","");
        public HomeController(DataContext context)
        {   
            _datacontext = context;
        }
        public IActionResult Allcurses()
        {
            var courses = _datacontext.curseslist.ToList();
            return View(courses);
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Materials(int id)
        {
            var Fo = _datacontext.curseslist.Find(id);
            
            if (Fo is null)
                return NotFound();

            return View(Fo);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult CreateKurs()
        {
            var liczba = _datacontext.curseslist.Count();
            ViewBag.liczbakursow = liczba;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateKurs([Bind("Id,Coursename,Professor,Learndifficulty,Notes")] Kurs kursow)
        {
            if (ModelState.IsValid)
            { 
                _datacontext.curseslist.Add(kursow);
                _datacontext.SaveChanges();
                var kursy = _datacontext.curseslist.ToList();
                return View("Allcurses", kursy);
            }
            else
            {
                return View(kursow);
            }
    }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}