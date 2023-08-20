namespace StudentsNotebook.Models
{
	public class NewMaterial
	{
		public string Path { get; set; }
		public int CourseId { get; set; }
		public IFormFile formFile { get; set; }
	}
}
