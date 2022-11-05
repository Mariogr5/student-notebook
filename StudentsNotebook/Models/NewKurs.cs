using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StudentsNotebook.Models
{
    public class NewKurs
    {
        [Required(ErrorMessage = "Wymagane ID")]
        [DisplayName("ID")]
        public int Kursid { get; set; }
        [Required(ErrorMessage = "Nazwa kursu wymagana")]
        [DisplayName("Nazwa")]
        public string Kursname { get; set; }
        [Required]
        [DisplayName("Prowadzący")]
        public string KursProfessor { get; set; }
        [DisplayName("Trudność kursu")]
        public string Kurslearndifficulty { get; set; }

    }
}
