﻿namespace StudentsNotebook.Models
{
	public class Material
	{
		public int Id { get; set; }
		public string Path { get; set; }
		public int CourseId { get; set; }
		public virtual Course Course { get; set; }
	}
}
