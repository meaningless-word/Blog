using AutoMapper;
using Blog.BLL.DTO;
using Blog.DAL.Entities;
using Blog.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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
		public async Task<IEnumerable<AuthorDTO>> GetAll()
		{
			var authors = await _unitOfWork.Authors.All();
			return _mapper.Map<IEnumerable<Author>, IEnumerable<AuthorDTO>>(authors);
		}

		public void Create(AuthorDTO author)
		{
			Author _author = _mapper.Map<AuthorDTO, Author>(author);
			_unitOfWork.Authors.Add(_author);
			_unitOfWork.CommitAsync();
		}

		public bool Delete(Guid id)
		{
			throw new NotImplementedException();
		}

		public AuthorDTO GetById(Guid id)
		{
			throw new NotImplementedException();
		}

		public bool Update(AuthorDTO author)
		{
			throw new NotImplementedException();
		}
	}
}
