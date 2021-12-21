using AutoMapper;
using Blog.BLL.DTO;
using Blog.BLL.Interfaces;
using Blog.DAL.Entities;
using Blog.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Blog.BLL.Services
{
	public class AuthorService : IAuthorService
	{
		private IUnitOfWork _unitOfWork;
		private IMapper _mapper;

		public AuthorService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public IEnumerable<AuthorDTO> GetAll()
		{
			var authors = _unitOfWork.Authors.All();
			var mapped = _mapper.Map<IEnumerable<Author>, IEnumerable<AuthorDTO>>(authors);
			return mapped;
		}

		public bool Create(AuthorDTO author)
		{
			var finded = _unitOfWork.Authors.Find(x => x.NickName == author.NickName).ToList();
			if (finded.Count == 0)
			{
				Author _author = _mapper.Map<AuthorDTO, Author>(author);
				_unitOfWork.Authors.Add(_author);
				_unitOfWork.Commit();
				return true;
			}
			return false;
		}

		public bool Delete(string id)
		{
			throw new NotImplementedException();
		}

		public AuthorDTO GetById(string id)
		{
			return _mapper.Map<AuthorDTO>(_unitOfWork.Authors.GetById(id));
		}

		public bool Update(AuthorDTO author)
		{
			throw new NotImplementedException();
		}
	}
}
