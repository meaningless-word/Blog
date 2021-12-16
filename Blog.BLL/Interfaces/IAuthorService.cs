using Blog.BLL.DTO;
using System.Collections.Generic;

namespace Blog.BLL.Interfaces
{
	public interface IAuthorService
	{
		IEnumerable<AuthorDTO> GetAll();
		bool Create(AuthorDTO author);
		bool Delete(string id);
		bool Update(AuthorDTO author);
		AuthorDTO GetById(string id);
	}
}
