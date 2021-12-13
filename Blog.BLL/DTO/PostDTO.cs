using System;
using System.Collections.Generic;

namespace Blog.BLL.DTO
{
	public class PostDTO
	{
		public Guid Id { get; set; }
		public string Context { get; set; }
		public DateTime Created { get; set; }
		public DateTime Modified { get; set; }
		public Guid AuthorId { get; set; }
		public string AuthorNickName { get; set; }
		public List<CommentDTO> Comments { get; set; };
		public List<TagDTO> Tags { get; set; };
	}
}
