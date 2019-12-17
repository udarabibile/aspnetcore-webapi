using webapi.domain.Models;

namespace webapi.data.Repositories
{
    public interface IUnitOfWork
    {
        IAuthorRepository AuthorRepository { get; }
        IRepository<Book> BookRepository { get; }
        void Commit();
        void Rollback();
    }
}