using DataAccess.Models;

namespace DataAccess.Repositories
{
    public interface IUnitOfWork
    {
        IAuthorRepository AuthorRepository { get; }
        IRepository<Book> BookRepository { get; }
        void Commit();
        void Rollback();
    }
}