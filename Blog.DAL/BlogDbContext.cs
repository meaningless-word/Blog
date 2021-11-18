using Blog.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blog.DAL
{
	public class BlogDbContext : DbContext
	{
		public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
		{
		}

		public DbSet<Author> Authors { get; set; }
		public DbSet<Tag> Tags { get; set; }
		public DbSet<Post> Posts { get; set; }
		public DbSet<Comment> Comments { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
