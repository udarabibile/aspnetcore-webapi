using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webapi.Models;

namespace webapi.Controllers
{
    [ApiController]
    [Route("api")]
    public class ApiController : ControllerBase
    {
        private readonly ILogger<ApiController> _logger;
        private readonly DatabaseContext _database;

        public ApiController(ILogger<ApiController> logger, DatabaseContext context)
        {
            _logger = logger;
            _database = context;
        }

        [HttpGet]
        [Route("users")]
        public List<User> GetAllUsers() => _database.getUsers();

        [HttpGet]
        [Route("books")]
        public List<Book> GetAllBooks() => _database.getBooks();

        [HttpPost]
        [Route("user")]
        [AllowAnonymous]
        public IActionResult AddUser([FromBody] User user)
        {
            _logger.LogInformation("Add User for UserId: {UserId}", user.UserId);
            _database.AddUser(user);
            return Ok(user);
        }

        [HttpPost]
        [Route("book")]
        [AllowAnonymous]
        public IActionResult AddBook([FromBody] Book book)
        {
            _logger.LogInformation("Add Book for BookId: {BookId}", book.BookId);
            _database.AddBook(book);
            return Ok(book);
        }

    }
}
