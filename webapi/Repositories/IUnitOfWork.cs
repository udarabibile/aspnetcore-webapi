using System;
using webapi.Models;

namespace webapi.Repositories
{
    public interface IUnitOfWork
    {
        IRepository<Author> AuthorRepository { get; }
        IRepository<Book> BookRepository { get; }
        void Save();
    }
}
