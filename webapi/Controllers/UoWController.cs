using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using webapi.Models;
using webapi.Repositories;

namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UoWConrtroller : ControllerBase
    {
        private IUnitOfWork _unitOfWork;

        public UoWConrtroller(IUnitOfWork unitOfWork)
            { _unitOfWork = unitOfWork; }

        [HttpGet]
        [Route("")]
        public IEnumerable<Author> GetAllBooks()
        {
            Book book = new Book();
            book.Title = "ALI";
            _unitOfWork.BookRepository.Insert(book);

            List<Book> books = new List<Book>();
            books.Add(book);

            Author author = new Author();
            author.Name = "HEY";
            author.Books = books;

            _unitOfWork.AuthorRepository.Insert(author);

            _unitOfWork.Save();

            return _unitOfWork.AuthorRepository.GetAll();
        }
    }
}