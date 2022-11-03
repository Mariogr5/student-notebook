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
                new Kurs(1, "Stefan", "medium"),
                new Kurs(2, "Wodard", "easy"),
                new Kurs(3, "Howard", "hard"),
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