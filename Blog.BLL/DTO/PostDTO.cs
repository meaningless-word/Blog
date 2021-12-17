using System;
using System.Collections.Generic;

namespace Blog.BLL.DTO
{
	public class PostDTO
	{
		public string Id { get; set; }
		public string Context { get; set; }
		public DateTime Created { get; set; }
		public DateTime Modified { get; set; }
		public string AuthorId { get; set; }
		public string AuthorNickName { get; set; }
		public List<CommentDTO> Comments { get; set; } = new List<CommentDTO>();
		public List<TagDTO> Tags { get; set; } = new List<TagDTO>();
		public string[] TagIds { get; set; }
	}
}
