using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using StudentsNotebook.Enums;

namespace StudentsNotebook.Models
{
    public class Course
    {
        [Required(ErrorMessage = "Wymagane ID")]
        [DisplayName("ID")]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Nazwa kursu wymagana")]
        [DisplayName("Nazwa")]
        public string Coursename { get; set; }
        [Required]
        [DisplayName("Prowadzący")]
        public string Professor { get; set; }
        [DisplayName("Trudność kursu")]
        public Difficult Learndifficulty { get; set; }
        public List<Material>? Notes { get; set; }
    }
}
