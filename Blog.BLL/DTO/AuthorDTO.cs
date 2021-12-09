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
		/// <summary>
		/// количество публикаций
		/// </summary>
		public int Posts { get; set; }
		/// <summary>
		/// количество комментариев
		/// </summary>
		public int Comments { get; set; }


		public AuthorDTO() {}

		public AuthorDTO(Guid id, string nickName)
		{
			Id = id;
			NickName = nickName;
		}
	}
}
