using System;
using System.ComponentModel.DataAnnotations;

namespace Blog.BLL.DTO
{
	public class AuthorDTO
	{
		public string Id { get; set; }

		[Required(ErrorMessage = "Не указан ник")]
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

		public AuthorDTO(string id, string nickName)
		{
			Id = id;
			NickName = nickName;
		}
	}
}
