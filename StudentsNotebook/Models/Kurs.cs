namespace StudentsNotebook.Models
{
    public class Kurs
    {
        public Kurs(int id, string coursename, string professor, string learndifficulty)
        {
            this.id = id;
            this.coursename = coursename;
            this.professor = professor;
            this.learndifficulty = learndifficulty;
        }
        public int id { get; set; }
        public string coursename { get; set; }
        public string professor { get; set; }
        public string learndifficulty { get; set; }
    }
}
