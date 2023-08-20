using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentsNotebook.Models;
using System.Diagnostics;

namespace StudentsNotebook.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _datacontext;
        private readonly IMapper _mapper;

        public HomeController(DataContext context, IMapper mapper)
        {   
            _datacontext = context;
            _mapper = mapper;
        }
        public IActionResult Allcurses()
        {
            var courses = _datacontext.curseslist
                .ToList();
            ViewBag.NumberofCourses = _datacontext.curseslist
                .Count();
            return View(courses);
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Materials(int id)
        {
            var courseMaterials = _datacontext.curseslist
                .Include(x => x.Notes)
                .FirstOrDefault(x => x.Id == id);
            
            if (courseMaterials is null)
                return NotFound();
            return View(courseMaterials);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult CreateKurs()
        {
            var numberofCourses = _datacontext.curseslist
                .Count();
            ViewBag.liczbakursow = numberofCourses;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateKurs([Bind("Coursename,Professor,Learndifficulty")] Course newCourse)
        {
            if (ModelState.IsValid)
            { 
                _datacontext.curseslist
                    .Add(newCourse);
                _datacontext
                    .SaveChanges();
                var courses = _datacontext.curseslist
                    .ToList();
                return View("Allcurses", courses);
            }
            else
            {
                return View(newCourse);
            }

        }
        public IActionResult AddMaterials(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        [HttpPost]
        public IActionResult AddMaterials(NewMaterial newmaterial)
        {
            newmaterial.Path = UploadFile(newmaterial.formFile);
            var material = _mapper.Map<Material>(newmaterial);
            if (material == null)
                return View("Materials", material);
            _datacontext.materials.Add(material);
            _datacontext.SaveChanges();
            var searchedCourse = _datacontext.curseslist
                .Include(x => x.Notes)
                .FirstOrDefault(x => x.Id == material.CourseId);
            return View("Materials", searchedCourse);

        }
        private string UploadFile(IFormFile formFile)
        {
            if (formFile != null && formFile.Length > 0)
            {
                var rootpath = Directory.GetCurrentDirectory();
                var fileName = formFile.FileName;
                var fullPath = $"{rootpath}/wwwroot/PrivateFiles/{fileName}";
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    formFile.CopyTo(stream);
                }
                return fullPath;
            }
            return null;
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}