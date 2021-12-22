using Blog.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

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

		public virtual IEnumerable<T> All()
		{
			throw new NotImplementedException();
		}

		public virtual T GetById(string id)
		{
			return dbSet.Find(id);
		}

		public virtual bool Add(T entity)
		{
			dbSet.Add(entity);
			return true;
		}

		public virtual bool Delete(string id)
		{
			throw new NotImplementedException();
		}
		public virtual bool Update(T entity)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
		{
			return dbSet.Where(predicate).ToList();
		}
	}
}
