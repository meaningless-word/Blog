using Blog.DAL.Entities;
using Blog.DAL.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Blog.DAL.Repositories
{
	public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
	{
		public AuthorRepository(BlogDbContext context, ILogger logger) : base(context, logger)
		{
		}

		public override IEnumerable<Author> All()
		{
			try
			{
				return dbSet.ToList();
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "{R} All function error", typeof(AuthorRepository));
				return new List<Author>();
			}
		}

		public override bool Update(Author entity)
		{
			try
			{
				var exist = dbSet.Where(x => x.Id == entity.Id).FirstOrDefault();
				dbSet.Update(entity);
				return exist != null;
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "{R} Update function error", typeof(AuthorRepository));
				return false;
			}
		}
	}
}
