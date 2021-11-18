using System;
using System.Threading.Tasks;

namespace Blog.DAL.Interfaces
{
	public interface IUnitOfWork<T> : IDisposable where T : class, IEntity
	{
		IAuthorRepository Authors { get; }
		IPostRepository Posts { get; }
		ICommentRepository Comments { get; }
		ITagRepository Tags { get; }

		Task CommitAsync();
	}
}
