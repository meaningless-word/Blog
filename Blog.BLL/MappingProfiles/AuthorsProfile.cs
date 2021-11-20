using AutoMapper;
using Blog.BLL.DTO;
using Blog.DAL.Entities;

namespace Blog.BLL.MappingProfiles
{
	public class AuthorsProfile : Profile
	{
		public AuthorsProfile()
		{
			CreateMap<Author, AuthorDTO>();
			CreateMap<AuthorDTO, Author>();
		}
	}
}
