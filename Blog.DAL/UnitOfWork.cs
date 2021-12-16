using Blog.DAL.Interfaces;
using Blog.DAL.Repositories;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Blog.DAL
{
	public class UnitOfWork : IUnitOfWork, IDisposable
	{
		private readonly BlogDbContext _context;
		private readonly ILogger _logger;

		public IAuthorRepository Authors { get; private set; }

		public IPostRepository Posts { get; private set; }

		public ICommentRepository Comments { get; private set; }

		public ITagRepository Tags { get; private set; }


		public UnitOfWork(BlogDbContext context, ILoggerFactory loggerFactory)
		{
			_context = context;
			_logger = loggerFactory.CreateLogger("logs");

			Posts = new PostRepository(context, _logger);
			Comments = new CommentRepository(context, _logger);
			Tags = new TagRepository(context, _logger);
			Authors = new AuthorRepository(context, _logger);
		}

		public void Commit()
		{
			_context.SaveChanges();
		}

		public void Dispose()
		{
			_context.Dispose();
		}
	}
}
