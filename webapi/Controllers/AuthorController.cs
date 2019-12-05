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

        public AuthorController(ILogger<AuthorController> logger, IAuthorRepository authorRepository)
        {
            _logger = logger;
            this.authorRepository = authorRepository;

        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Author> GetAllAuthots() => authorRepository.GetAll();

    }
}
