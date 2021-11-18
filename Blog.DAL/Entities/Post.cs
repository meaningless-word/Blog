using System;
using System.Collections.Generic;

namespace Blog.DAL.Entities
{
	public class Post : BaseEntity
	{
		public string Context { get; set; }

		public Guid AuthorId { get; set; }

		/// <summary>
		/// навигационное свойство - у публикации один автор
		/// </summary>
		public Author Author { get; set; }

		/// <summary>
		/// навигационное свойство - комментарии, относящиеся к публикации
		/// </summary>
		public List<Comment> Comments { get; set; } = new List<Comment>();

		/// <summary>
		/// навигационное свойство - все теги статьи
		/// </summary>
		public List<Tag> Tags { get; set; } = new List<Tag>();
	}
}
