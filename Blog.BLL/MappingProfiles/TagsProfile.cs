using AutoMapper;
using Blog.BLL.DTO;
using Blog.DAL.Entities;

namespace Blog.BLL.MappingProfiles
{
	public class TagsProfile : Profile
	{
		public TagsProfile()
		{
			CreateMap<Tag, TagDTO>();
			CreateMap<TagDTO, Tag>();
		}
	}
}