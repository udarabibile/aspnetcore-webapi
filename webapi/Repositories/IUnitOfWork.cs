using webapi.Models;

namespace webapi.Repositories
{
    public interface IUnitOfWork
    {
        IAuthorRepository AuthorRepository { get; }
        IRepository<Book> BookRepository { get; }
        void Commit();
        void Rollback();
    }
}