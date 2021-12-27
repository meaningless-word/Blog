using Blog.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Blog.BLL.Interfaces
{
	public interface ITagService
	{
		IEnumerable<TagDTO> GetAll();
		void Create(TagDTO tag);
		bool Delete(string id);
		TagDTO GetById(string id);
		bool Update(TagDTO tag);
	}
}
