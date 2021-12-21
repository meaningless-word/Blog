using System.Collections.Generic;
using Blog.BLL.DTO;

namespace Blog.BLL.Interfaces
{
	public interface ICommentService
	{
		IEnumerable<CommentDTO> GetByPostId(string postId);
		void Create(CommentDTO comment);
	}
}