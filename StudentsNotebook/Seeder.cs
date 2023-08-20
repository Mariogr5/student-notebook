using Microsoft.EntityFrameworkCore;
using StudentsNotebook.Enums;
using StudentsNotebook.Models;

namespace StudentsNotebook
{
	public class Seeder
	{
		private readonly DataContext _context;

		public Seeder(DataContext context)
		{
			_context = context;
		}
        public void Seed()
        {
            if (_context.Database.CanConnect())
            {
                if (!_context.curseslist.Any())
                {
                    var courses = GetCourses();
                    _context.AddRange(courses);
                    _context.SaveChanges();
                }
            }
        }

        private IEnumerable<Course> GetCourses()
        {
            var courses = new List<Course>()
            {
                new Course()
                {
                    Coursename = "Math",
                    Professor = "Ned Stark",
                    Learndifficulty = Difficult.Hard
                },
                new Course()
                {
                    Coursename = "Physics",
                    Professor = "Sansa Stark",
                    Learndifficulty = Difficult.Hard
                },
                new Course()
                {
                    Coursename = "Computer Science",
                    Professor = "Jame Lannister",
                    Learndifficulty = Difficult.Easy
                },
            };
            return courses;
        }
    }
}
