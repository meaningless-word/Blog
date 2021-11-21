using System;
using System.ComponentModel.DataAnnotations;

namespace Blog.BLL.DTO
{
	public class AuthorDTO
	{
		public Guid Id { get; set; }

		[Required]
		[MaxLength(30)]
		public string NickName { get; set; }

		public int Posts { get; set; }

		public int Comments { get; set; }


		public AuthorDTO() {}

		public AuthorDTO(Guid id, string nickName)
		{
			this.Id = id;
			this.NickName = nickName;
		}
	}
}
