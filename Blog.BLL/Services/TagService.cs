using AutoMapper;
using Blog.BLL.DTO;
using Blog.BLL.Interfaces;
using Blog.DAL.Entities;
using Blog.DAL.Interfaces;
using System.Collections.Generic;

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
			
		public IEnumerable<TagDTO> GetAll()
		{
			var tags = _unitOfWork.Tags.All();
			return _mapper.Map<IEnumerable<Tag>, IEnumerable<TagDTO>>(tags);
		}

		public void Create(TagDTO tag)
		{
			var _tag = _mapper.Map<TagDTO, Tag>(tag);
			_unitOfWork.Tags.Add(_tag);
			_unitOfWork.Commit();
		}

		public bool Delete(string id)
		{
			var tag = _unitOfWork.Tags.GetById(id);

			if (tag == null)
			{
				return false;
			}

			var result = _unitOfWork.Tags.Delete(id);
			_unitOfWork.Commit();
			return result;
		}

		public TagDTO GetById(string id)
		{
			var tag = _unitOfWork.Tags.GetById(id);
			return _mapper.Map<Tag, TagDTO>(tag);
		}

		public bool Update(TagDTO tag)
		{
			var _tag = _unitOfWork.Tags.GetById(tag.Id);

			if (_tag == null)
			{
				return false;
			}

			_tag.Name = tag.Name;
			var result = _unitOfWork.Tags.Update(_tag);
			_unitOfWork.Commit();
			return result;
		}
	}
}
