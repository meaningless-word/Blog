using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			this.Id = id;
			this.Content = content;
			this.Created = created;
			this.Modified = modified;
			this.AuthorId = authorId;
			this.PostId = postId;
		}
	}
}
