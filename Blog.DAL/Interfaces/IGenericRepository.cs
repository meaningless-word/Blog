using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Blog.DAL.Interfaces
{
	public interface IGenericRepository<T> where T : class
	{
		Task<IEnumerable<T>> All();
		Task<T> GetById(Guid id);
		Task<bool> Add(T entity);
		Task<bool> Delete(Guid id);
		Task<bool> Update(T entity);
		Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);

	}
}
