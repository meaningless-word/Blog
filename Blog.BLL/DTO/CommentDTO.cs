using System;

namespace Blog.BLL.DTO
{
	public class CommentDTO
	{
		public string Id { get; set; }
		public string Content { get; set; }
		public DateTime Created { get; set; }
		public DateTime Modified { get; set; }
		public string AuthorId { get; set; }
		public string PostId { get; set; }
	}
}
