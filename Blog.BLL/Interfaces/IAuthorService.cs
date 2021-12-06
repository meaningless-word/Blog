using Blog.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.BLL
{
	public interface IAuthorService
	{
		Task<IEnumerable<AuthorDTO>> GetAll();
		void Create(AuthorDTO author);
		bool Delete(Guid id);
		bool Update(AuthorDTO author);
		AuthorDTO GetById(Guid id);
	}
}
