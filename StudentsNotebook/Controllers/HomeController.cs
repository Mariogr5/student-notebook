using Microsoft.AspNetCore.Mvc;
using StudentsNotebook.Models;
using System.Diagnostics;

namespace StudentsNotebook.Controllers
{
    public class HomeController : Controller
    {
        List<Kurs> curseslist;
        Kurs sam = new Kurs(2,"","","","");
        public HomeController()
        {
            curseslist = new List<Kurs>()
            {
                new Kurs(1, "Podstawy produkcji metaamfetaminy", "Włodzimierz Biały", "medium", "wzorynacalki.jpg"),
                new Kurs(2, "Ziołoznawstwo 3.3", "Jeremiasz Różowy", "easy","wzorynacalki.jpg"),
                new Kurs(3, "Podstawy samoobrony", "Heniek Szreder", "hard","wzorynacalki.jpg"),
                new Kurs(4, "Zarządzanie", "Gustaw Fring", "hard","wzorynacalki.jpg"),
            };    
        }
        public IActionResult Allcurses()
        {
            return View(curseslist);
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Materials(int id)
        {
            var rzeczy = curseslist.FirstOrDefault(p => p.Id == id);
            return View(rzeczy);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult CreateKurs()
        {
            var liczba = curseslist.Count();
            ViewBag.liczbakursow = liczba;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateKurs([Bind("Id,Coursename,Professor,Learndifficulty,Notes")] Kurs kursow)
        {
            if (ModelState.IsValid)
            { 
                curseslist.Add(kursow);
                return View("Allcurses", curseslist);
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