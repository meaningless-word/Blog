using Blog.DAL.Entities;
using Blog.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
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

		public override bool Add(Author entity)
		{
			entity.Id = Guid.NewGuid().ToString().ToUpper();
			return base.Add(entity);
		}

		public override IEnumerable<Author> All()
		{
			try
			{
				return dbSet.Include("Posts").Include("Comments").ToList();
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
