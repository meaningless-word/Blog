using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Blog.BLL.DTO
{
	public class TagDTO
	{
		[Key]
		public string Id { get; set; }

		[DisplayName("наименование")]
		[Required]
		[MaxLength(20)]
		public string Name { get; set; }
	}
}
