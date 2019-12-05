using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webapi.Models;
using webapi.Repositories;

namespace webapi.Controllers
{
    [ApiController]
    [Route("book")]
    public class BookController : ControllerBase
    {
        private readonly ILogger<BookController> _logger;
        private IRepository<Book> bookRepository;

        public BookController(ILogger<BookController> logger, IRepository<Book> bookRepository)
        {
            _logger = logger;
            this.bookRepository = bookRepository;

        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Book> GetAllBooks() => bookRepository.GetAll();

    }
}