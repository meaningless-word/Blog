using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.DAL.Entities
{
	public class Author : BaseEntity
	{
		[Required]
		[MaxLength(30)]
		public string NickName { get; set; }

		/// <summary>
		/// навигационное свойство - все комментарии автора
		/// </summary>
		public List<Comment> Comments { get; set; } = new List<Comment>();

		/// <summary>
		/// навигационное свойство - все публикации автора
		/// </summary>
		public List<Post> Posts { get; set; } = new List<Post>();

		[ForeignKey("ApplicationUser")]
		public string ApplicationUserId { get; set; }

		public ApplicationUser ApplicationUser { get; set; }
	}
}
