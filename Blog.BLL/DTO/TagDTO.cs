using System;
using System.ComponentModel.DataAnnotations;

namespace Blog.BLL.DTO
{
	public class TagDTO
	{
		public Guid Id { get; set; }
		
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
