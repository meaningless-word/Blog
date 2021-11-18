using Blog.DAL.Entities;
using Blog.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.DAL.Repositories
{
	public class TagRepository : GenericRepository<Tag>, ITagRepository
	{
		public TagRepository(BlogDbContext context, ILogger logger) : base(context, logger)
		{
		}

		public override async Task<IEnumerable<Tag>> All()
		{
			try
			{
				return await dbSet.ToListAsync();
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "{R} All function error", typeof(TagRepository));
				return new List<Tag>();
			}
		}

		public override async Task<bool> Delete(Guid id)
		{
			try
			{
				var exist = await dbSet.Where(x => x.Id == id).FirstOrDefaultAsync();

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

		public override async Task<bool> Update(Tag entity)
		{
			try
			{
				var exist = await dbSet.Where(x => x.Id == entity.Id).FirstOrDefaultAsync();
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
