using Blog.DAL.Entities;
using Blog.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Blog.DAL.Repositories
{
	public class TagRepository : GenericRepository<Tag>, ITagRepository
	{
		public TagRepository(BlogDbContext context, ILogger logger) : base(context, logger)
		{
		}

		public override bool Add(Tag entity)
		{
			entity.Id = Guid.NewGuid().ToString().ToUpper();
			return base.Add(entity);
		}
		public override IEnumerable<Tag> All()
		{
			try
			{
				return dbSet.Include("Posts").ToList();
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "{R} All function error", typeof(TagRepository));
				return new List<Tag>();
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
				_logger.LogError(ex, "{R} Delete function error", typeof(TagRepository));
				return false;
			}
		}

		public override bool Update(Tag entity)
		{
			try
			{
				var exist = dbSet.Where(x => x.Id == entity.Id).FirstOrDefault();
				dbSet.Update(entity);
				return exist != null;
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "{R} Update function error", typeof(TagRepository));
				return false;
			}
		}
	}
}
