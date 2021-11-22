using AutoMapper;
using Blog.BLL.DTO;
using Blog.DAL.Entities;
using Blog.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

		public void Create(TagDTO tag)
		{
			var _tag = _mapper.Map<TagDTO, Tag>(tag);
			_unitOfWork.Tags.Add(_tag);
			_unitOfWork.CommitAsync();
		}

		public async Task<bool> Delete(Guid id)
		{
			var _tags = await _unitOfWork.Tags.Find(x => x.Id == id);
			var _tag = _tags.FirstOrDefault();

			if (_tag == null)
			{
				return false;
			}

			return await _unitOfWork.Tags.Delete(id);
		}
	}
}
