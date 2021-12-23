using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blog.DAL.Entities
{
	[Index(nameof(Name), IsUnique = true)]
	public class Tag
	{
		[Key]
		[MaxLength(36)]
		public string Id { get; set; }

		[MaxLength(20)]
		public string Name { get; set; }

		/// <summary>
		/// навигационное свойство - все статьи под этим тегом
		/// </summary>
		public List<Post> Posts { get; set; } = new List<Post>();
	}
}
