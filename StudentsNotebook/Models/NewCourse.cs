using StudentsNotebook.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StudentsNotebook.Models
{
    public class NewCourse
    {
        [Required(ErrorMessage = "Wymagane ID")]
        [DisplayName("ID")]
        public int Courseid { get; set; }
        [Required(ErrorMessage = "Nazwa kursu wymagana")]
        [DisplayName("Nazwa")]
        public string Coursename { get; set; }
        [Required]
        [DisplayName("Prowadzący")]
        public string CourseProfessor { get; set; }
        [DisplayName("Trudność kursu")]
        public Difficult CourseLearnDifficulty { get; set; }

    }
}
