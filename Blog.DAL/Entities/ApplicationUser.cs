using Microsoft.AspNetCore.Identity;

namespace Blog.DAL.Entities
{
	public class ApplicationUser : IdentityUser
	{
		public Author Author { get; set; }
	}
}
