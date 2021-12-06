﻿using Blog.DAL.Entities;
using Blog.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.DAL.Repositories
{
	public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
	{
		public AuthorRepository(BlogDbContext context, ILogger logger) : base(context, logger)
		{
		}

		public override async Task<IEnumerable<Author>> All()
		{
			try
			{
				return await dbSet.ToListAsync();
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "{R} All function error", typeof(AuthorRepository));
				return new List<Author>();
			}
		}

		public async Task<bool> Delete(string nickName)
		{
			try
			{
				var exist = await dbSet.Where(x => x.NickName == nickName).FirstOrDefaultAsync();

				if (exist == null) return false;

				dbSet.Remove(exist);
				return true;
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "{R} Delete function error", typeof(AuthorRepository));
				return false;
			}
		}

		public override async Task<bool> Update(Author entity)
		{
			try
			{
				var exist = await dbSet.Where(x => x.Id == entity.Id).FirstOrDefaultAsync();
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
