using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.DAL.Entities
{
	public class Comment
	{
		[Key]
		[MaxLength(36)]
		public string Id { get; set; }
		public string Content { get; set; }
		public DateTime Created { get; set; }
		public DateTime Modified { get; set; }

		/// <summary>
		/// внешний ключ
		/// </summary>
		[MaxLength(36)]
		[ForeignKey("Author")]
		public string AuthorId { get; set; }

		/// <summary>
		/// навигационное свойство - у комментария один автор
		/// </summary>
		public Author Author { get; set; }

		/// <summary>
		/// внешний ключ
		/// </summary>
		[MaxLength(36)]
		[ForeignKey("Post")]
		public string PostId { get; set; }
		/// <summary>
		/// навигационное свойство - комментарий относится к конкретной статье
		/// </summary>
		public Post Post { get; set; }
	}
}
