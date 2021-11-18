using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blog.DAL.Entities
{
	public class Tag : BaseEntity
	{
		[MaxLength(20)]
		public string Name { get; set; }

		/// <summary>
		/// навигационное свойство - все статьи под этим тегом
		/// </summary>
		public List<Post> Posts { get; set; } = new List<Post>();
	}
}
