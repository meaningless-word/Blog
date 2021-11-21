using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BLL.DTO
{
	public class PostDTO
	{
		public Guid Id { get; set; }
		public string Context { get; set; }
		public DateTime Created { get; set; }
		public DateTime Modified { get; set; }

		public Guid AuthorId { get; set; }


		public PostDTO() {}

		public PostDTO(Guid id, string context, DateTime created, DateTime modified)
		{
			this.Id = id;
			this.Context = context;
			this.Created = created;
			this.Modified = modified;
		}
	}
}
