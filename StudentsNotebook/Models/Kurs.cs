using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace StudentsNotebook.Models
{
    public class Kurs
    {
        public Kurs(int id, string coursename, string professor, string learndifficulty, string notes)
        {
            this.Id = id;
            this.Coursename = coursename;
            this.Professor = professor;
            this.Learndifficulty = learndifficulty;
            this.Notes = notes;
        }
        public Kurs()
        {
            this.Id = 0;
            this.Coursename = "";
            this.Professor = "";
            this.Learndifficulty = "";
            this.Notes = "";
        }
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
        public string Learndifficulty { get; set; }
        public string Notes { get; set; }
    }
}
