using System;

namespace Blog.DAL.Entities
{
	public class Comment : BaseEntity
	{
		public string Content { get; set; }
		public DateTime Created { get; set; }
		public DateTime Modified { get; set; }

		/// <summary>
		/// внешний ключ
		/// </summary>
		public Guid AuthorId { get; set; }

		/// <summary>
		/// навигационное свойство - у комментария один автор
		/// </summary>
		public Author Author { get; set; }

		/// <summary>
		/// навигационное свойство - комментарий относится к конкретной статье
		/// </summary>
		public Post Post { get; set; }
	}
}
