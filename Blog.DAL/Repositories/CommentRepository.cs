using Blog.DAL.Entities;
using Blog.DAL.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Blog.DAL.Repositories
{
	public class CommentRepository : GenericRepository<Comment>, ICommentRepository
	{
		public CommentRepository(BlogDbContext context, ILogger logger) : base(context, logger)
		{
		}

		public override IEnumerable<Comment> All()
		{
			try
			{
				return dbSet.ToList();
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "{R} All function error", typeof(CommentRepository));
				return new List<Comment>();
			}
		}

		public override bool Delete(string id)
		{
			try
			{
				var exist = dbSet.Where(x => x.Id == id).FirstOrDefault();

				if (exist == null) return false;

				dbSet.Remove(exist);
				return true;
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "{R} Delete function error", typeof(CommentRepository));
				return false;
			}
		}

		public override bool Update(Comment entity)
		{
			try
			{
				var exist = dbSet.Where(x => x.Id == entity.Id).FirstOrDefault();
				dbSet.Update(entity);
				return exist != null;
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "{R} Update function error", typeof(CommentRepository));
				return false;
			}
		}
	}
}
