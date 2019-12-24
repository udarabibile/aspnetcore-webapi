using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using webapi.core.Models;
using webapi.business.Services;
using System.Threading.Tasks;

namespace webapi.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private IBookService bookService;

        public BookController(IBookService bookService)
        { this.bookService = bookService; }

        [HttpGet("")]
        public IEnumerable<Book> GetAllBooks() =>bookService.GetAllBooks();

        [HttpGet]
        [Route("id/{bookId}")]
        public Book GetBookById(Guid bookId) => bookService.GetBookById(bookId);

        [HttpPost]
        [Route("")]
        [AllowAnonymous]
        public void AddBook([FromBody] Book book) => bookService.CreateBook(book);

        [HttpDelete]
        [Route("{bookId}")]
        [AllowAnonymous]
        public void DeleteBook(Guid bookId) => bookService.DeleteBook(bookId);


        [HttpGet("sample")]
        public Task<Author> CreateSample() => bookService.CreateSampleBookWithAuthor();
    }
}