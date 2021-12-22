using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Blog.DAL.Interfaces
{
	public interface IGenericRepository<T> where T : class
	{
		IEnumerable<T> All();
		T GetById(string id);
		bool Add(T entity);
		bool Delete(string id);
		bool Update(T entity);
		IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

	}
}
