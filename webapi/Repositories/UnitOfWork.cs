using System;
using webapi.Models;

namespace webapi.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _databaseContext;
        private IRepository<Author> _authorRepository;
        private IRepository<Book> _bookRepository;
        public UnitOfWork(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public IRepository<Author> AuthorRepository
        {
            get
            {
                return _authorRepository = _authorRepository ?? new Repository<Author>(_databaseContext);
            }
        }

        public IRepository<Book> BookRepository
        {
            get
            {
                return _bookRepository = _bookRepository ?? new Repository<Book>(_databaseContext);
            }
        }

        public void Save()
        {
            _databaseContext.SaveChanges();
        }
    }
}
