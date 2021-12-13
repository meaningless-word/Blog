using AutoMapper;
using Blog.BLL.DTO;
using Blog.BLL.Interfaces;
using Blog.DAL.Entities;
using Blog.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

		public async Task<IEnumerable<PostDTO>> GetAll()
		{
			var posts = await _unitOfWork.Posts.All();
			return _mapper.Map<IEnumerable<Post>, IEnumerable<PostDTO>> (posts);
		}
	}
}
