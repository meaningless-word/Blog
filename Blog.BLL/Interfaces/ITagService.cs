using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blog.BLL.DTO;

namespace Blog.BLL
{
	public interface ITagService
	{
		Task<IEnumerable<TagDTO>> GetAll();
		void Create(TagDTO tag);
		Task<bool> Delete(Guid id);
		Task<TagDTO> GetById(Guid id);
	}
}
