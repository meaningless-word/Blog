namespace Blog.DAL.Interfaces
{
	public interface IUnitOfWork
	{
		IAuthorRepository Authors { get; }
		IPostRepository Posts { get; }
		ICommentRepository Comments { get; }
		ITagRepository Tags { get; }

		void Commit();
	}
}
