using Microsoft.AspNetCore.Mvc;
using StudentsNotebook.Models;
using System.Diagnostics;

namespace StudentsNotebook.Controllers
{
    public class HomeController : Controller
    {
        List<Kurs> curseslist;
        public HomeController()
        {
            curseslist = new List<Kurs>()
            {
                new Kurs(1, "Podstawy produkcji metaamfetaminy", "Włodzimierz Biały", "medium"),
                new Kurs(2, "Picie dla zaawansowanych", "Jeremiasz Różowy", "easy"),
                new Kurs(3, "Podstawy samoobrony", "Heniek Szreder", "hard"),
                new Kurs(4, "Zarządzanie", "Gustaw Fring", "hard"),
            };

            
        }
        public IActionResult Allcurses()
        {
            return View(curseslist);
        }
        public IActionResult Opinion(int id)
        {

            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}