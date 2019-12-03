using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webapi.Models;
using webapi.Repositories;

namespace webapi.Controllers
{
    [ApiController]
    [Route("author")]
    public class AuthorController : ControllerBase
    {
        private readonly ILogger<AuthorController> _logger;
        // private readonly DatabaseContext _database;

        private IRepository<Author> authorRepository;
        private IRepository<Book> bookRepository;

        public AuthorController(ILogger<AuthorController> logger, IRepository<Author> authorRepository, IRepository<Book> bookRepository)
        {
            _logger = logger;
            // _database = context;
            this.authorRepository = authorRepository;
            this.bookRepository = bookRepository;

        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Author> GetAllAuthots() => authorRepository.GetAll();

    }
}
