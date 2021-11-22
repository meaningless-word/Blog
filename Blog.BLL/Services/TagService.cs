using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Blog.BLL.DTO;
using Blog.DAL.Entities;
using Blog.DAL.Interfaces;
using Microsoft.Extensions.Logging;

namespace Blog.BLL.Services
{
	public class TagService : ITagService
	{
		private IUnitOfWork _unitOfWork;
		private IMapper _mapper;

		public TagService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}
			
			
		public async Task<IEnumerable<TagDTO>> GetAll()
		{
			var tags = await _unitOfWork.Tags.All();
			return _mapper.Map<IEnumerable<Tag>, IEnumerable<TagDTO>>(tags);
		}
	}
}
