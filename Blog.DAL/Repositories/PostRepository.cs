using Blog.DAL.Entities;
using Blog.DAL.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Blog.DAL.Repositories
{
	public class PostRepository : GenericRepository<Post>, IPostRepository
	{
		public PostRepository(BlogDbContext context, ILogger logger) : base(context, logger)
		{
		}

		public override bool Add(Post entity)
		{
			entity.Id = Guid.NewGuid().ToString().ToUpper();
			return base.Add(entity);
		}

		public override IEnumerable<Post> All()
		{
			try
			{
				return dbSet.ToList();
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "{R} All function error", typeof(PostRepository));
				return new List<Post>();
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
				_logger.LogError(ex, "{R} Delete function error", typeof(PostRepository));
				return false;
			}
		}

		public override bool Update(Post entity)
		{
			try
			{
				var exist = dbSet.Where(x => x.Id == entity.Id).FirstOrDefault();
				dbSet.Update(entity);
				return exist != null;
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "{R} Update function error", typeof(PostRepository));
				return false;
			}
		}
	}
}
