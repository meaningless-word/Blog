using Blog.DAL.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace Blog.DAL.Entities
{
	public class BaseEntity : IEntity
	{
		public BaseEntity()
		{
			Id = Guid.NewGuid().ToString().ToUpper();
		}
		[Key]
		[MaxLength(36)]
		public string Id { get; set; }
	}
}
