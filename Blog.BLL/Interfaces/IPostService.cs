using Blog.BLL.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.BLL.Interfaces
{
	public interface IPostService
	{
		Task<IEnumerable<PostDTO>> GetAll();
		void Create(PostDTO post);
	}
}
