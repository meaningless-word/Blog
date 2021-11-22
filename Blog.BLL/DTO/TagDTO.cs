using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Blog.BLL.DTO
{
	public class TagDTO
	{
		[Key]
		public Guid Id { get; set; }

		[DisplayName("наименование")]
		[Required]
		[MaxLength(20)]
		public string Name { get; set; }


		public TagDTO() {}

		public TagDTO(Guid id, string name)
		{
			this.Id = id;
			this.Name = name;
		}
	}
}
