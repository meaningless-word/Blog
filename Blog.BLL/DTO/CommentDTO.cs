using System;

namespace Blog.BLL.DTO
{
	public class CommentDTO
	{
		public Guid Id { get; set; }
		public string Content { get; set; }
		public DateTime Created { get; set; }
		public DateTime Modified { get; set; }
		public Guid AuthorId { get; set; }
		public Guid PostId { get; set; }

		public CommentDTO() {}

		public CommentDTO(Guid id, string content, DateTime created, DateTime modified, Guid authorId, Guid postId)
		{
			Id = id;
			Content = content;
			Created = created;
			Modified = modified;
			AuthorId = authorId;
			PostId = postId;
		}
	}
}
