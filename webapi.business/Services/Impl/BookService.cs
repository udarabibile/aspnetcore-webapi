using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using webapi.core.Models;
using webapi.data.Repositories;

namespace webapi.business.Services.Impl
{
    public class BookService : IBookService
    {
        private IUnitOfWork _unitOfWork;

        public BookService(IUnitOfWork unitOfWork)
        { _unitOfWork = unitOfWork; }

        public IEnumerable<Book> GetAllBooks() => _unitOfWork.BookRepository.GetAll();
        public Book GetBookById(Guid bookId) => _unitOfWork.BookRepository.GetById(bookId);
        public void CreateBook(Book book)
        {
            _unitOfWork.BookRepository.Insert(book);
            _unitOfWork.Commit();
            return;
        }

        public void DeleteBook(Guid bookId)
        {
            _unitOfWork.BookRepository.Delete(bookId);
            _unitOfWork.Commit();

        }
        public Task<Author> CreateSampleBookWithAuthor()
        {
            Book gambler = new Book("The Gambler");
            Author fyodor = new Author("Fyodor Dostoyevsky", "Russia", new List<Book>() { gambler });

            try
            {
                _unitOfWork.BookRepository.Insert(gambler);
                _unitOfWork.AuthorRepository.Insert(fyodor);
                _unitOfWork.Commit();
            }
            catch
            {
                _unitOfWork.Rollback();
                return Task.FromResult(new Author());
            }

            return _unitOfWork.AuthorRepository.GetByName(fyodor.Name);
        }
    }
}
