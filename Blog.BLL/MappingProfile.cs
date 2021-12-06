using AutoMapper;
using Blog.BLL.DTO;
using Blog.DAL.Entities;

namespace Blog.BLL
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<Tag, TagDTO>();
			CreateMap<TagDTO, Tag>();
			CreateMap<Author, AuthorDTO>();
			CreateMap<AuthorDTO, Author>();
		}
	}
}