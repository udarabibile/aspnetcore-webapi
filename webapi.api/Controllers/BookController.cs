// using System;
// using System.Collections.Generic;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Authorization;
// using webapi.core.Models;
// using DataAccess.Repositories;

// namespace webapi.Controllers
// {
//     [ApiController]
//     [Route("[controller]")]
//     public class BookController : ControllerBase
//     {
//         private IRepository<Book> bookRepository;
//         public BookController(IRepository<Book> bookRepository)
//             { this.bookRepository = bookRepository;}

//         [HttpGet]
//         [Route("")]
//         public IEnumerable<Book> GetAllBooks() => bookRepository.GetAll();

//         [HttpGet]
//         [Route("{bookId}")]
//         public Book GetBookById(Guid bookId) => bookRepository.GetById(bookId);

//         [HttpPost]
//         [Route("")]
//         [AllowAnonymous]
//         public void AddBook([FromBody] Book book) => bookRepository.Insert(book);

//         [HttpDelete]
//         [Route("{bookId}")]
//         [AllowAnonymous]
//         public void DeleteBook(Guid bookId) => bookRepository.Delete(bookId);
//     }
// }