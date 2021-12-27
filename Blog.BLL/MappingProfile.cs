using AutoMapper;
using Blog.BLL.DTO;
using Blog.DAL.Entities;
using System.Collections.Generic;

namespace Blog.BLL
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<Tag, TagDTO>();
			CreateMap<TagDTO, Tag>()
				.ForMember(a => a.Id, map => map.MapFrom(src => src.Id));
			CreateMap<Author, AuthorDTO>()
				.ForMember(a => a.Comments, map => map.MapFrom(src => src.Comments.Count))
				.ForMember(a => a.Posts, map => map.MapFrom(src => src.Posts.Count));
			CreateMap<AuthorDTO, Author>()
				.ForMember(a => a.Id, map => map.MapFrom(src => src.Id))
				.ForMember(a => a.NickName, map => map.MapFrom(src => src.NickName))
				.ForMember(a => a.Posts, map => map.MapFrom(src => new List<Post>()))
				.ForMember(a => a.Comments, map => map.MapFrom(src => new List<Comment>()));
			CreateMap<Post, PostDTO>()
				.ForMember(a => a.AuthorNickName, map => map.MapFrom(src => src.Author.NickName))
				.ForMember(a => a.Comments, map => map.MapFrom(src => src.Comments))
				.ForMember(a => a.Tags, map => map.MapFrom(src => src.Tags));
			CreateMap<PostDTO, Post>()
				.ForMember(a => a.Id, map => map.MapFrom(src => src.Id))
				.ForMember(a => a.Tags, map => map.MapFrom(src => src.Tags));
			CreateMap<Comment, CommentDTO>();
			CreateMap<CommentDTO, Comment>();
		}
	}
}