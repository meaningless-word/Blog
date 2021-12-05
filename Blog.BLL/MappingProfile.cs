using AutoMapper;
using Blog.BLL.DTO;
using Blog.DAL.Entities;

namespace Blog.BLL
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<Tag, TagDTO>()
				.ForMember(a => a.Name, m => m.MapFrom(src => src.Name));
			CreateMap<TagDTO, Tag>();
			CreateMap<Author, AuthorDTO>();
			CreateMap<AuthorDTO, Author>();
		}
	}
}