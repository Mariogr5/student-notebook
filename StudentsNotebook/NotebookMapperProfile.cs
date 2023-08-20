using AutoMapper;
using StudentsNotebook.Models;

namespace StudentsNotebook
{
	public class NotebookMapperProfile : Profile
	{
		public NotebookMapperProfile()
		{
			CreateMap<NewMaterial, Material>();
		}
	}
}
