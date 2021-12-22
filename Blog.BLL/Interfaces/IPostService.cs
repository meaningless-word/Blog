using Blog.BLL.DTO;
using System.Collections.Generic;

namespace Blog.BLL.Interfaces
{
	public interface IPostService
	{
		IEnumerable<PostDTO> GetAll();
		IEnumerable<PostDTO> GetPostsByAuthorId(string id);
		void Create(PostDTO post);
	}
}
