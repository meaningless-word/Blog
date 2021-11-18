using Blog.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Blog.DAL.Repositories
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{
		protected BlogDbContext _context;
		internal DbSet<T> dbSet;
		public readonly ILogger _logger;

		public GenericRepository(BlogDbContext context, ILogger logger)
		{
			_context = context;
			dbSet = context.Set<T>();
			_logger = logger;
		}

		public virtual Task<IEnumerable<T>> All()
		{
			throw new NotImplementedException();
		}

		public virtual async Task<T> GetById(Guid id)
		{
			return await dbSet.FindAsync(id);
		}

		public virtual async Task<bool> Add(T entity)
		{
			await dbSet.AddAsync(entity);
			return true;
		}

		public virtual Task<bool> Delete(Guid id)
		{
			throw new NotImplementedException();
		}
		public virtual Task<bool> Update(T entity)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate)
		{
			return await dbSet.Where(predicate).ToListAsync();
		}
	}
}
