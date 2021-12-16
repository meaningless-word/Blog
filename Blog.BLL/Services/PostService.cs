using AutoMapper;
using Blog.BLL.DTO;
using Blog.BLL.Interfaces;
using Blog.DAL.Entities;
using Blog.DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace Blog.BLL.Services
{
	public class PostService : IPostService
	{
		private IUnitOfWork _unitOfWork;
		private IMapper _mapper;

		public PostService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public IEnumerable<PostDTO> GetAll()
		{
			var posts = _unitOfWork.Posts.All();
			return _mapper.Map<IEnumerable<Post>, IEnumerable<PostDTO>> (posts);
		}

		public void Create(PostDTO post)
		{
			var _post = _mapper.Map<PostDTO, Post>(post);

			//Post _post = new Post() { Context = post.Context };
			//_post.Tags = new List<Tag>();
			//_post.Tags.AddRange(_unitOfWork.Tags.All());
			
			
			_post.Created = DateTime.Now;
			_post.Modified = DateTime.Now;

			_unitOfWork.Posts.Add(_post);
			_unitOfWork.Commit();
		}
	}
}
