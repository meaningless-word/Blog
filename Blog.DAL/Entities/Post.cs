using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.DAL.Entities
{
	public class Post
	{
		[Key]
		[MaxLength(36)]
		public string Id { get; set; }
		public string Context { get; set; }
		public DateTime Created { get; set; }
		public DateTime Modified { get; set; }

		[MaxLength(36)]
		[ForeignKey("Author")]
		public string AuthorId { get; set; }

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
