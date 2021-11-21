using Blog.DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Blog.DAL
{
	public class BlogDbContext : IdentityDbContext<Author>
	{
		public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
		{
		}

		public DbSet<Tag> Tags { get; set; }
		public DbSet<Post> Posts { get; set; }
		public DbSet<Comment> Comments { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
