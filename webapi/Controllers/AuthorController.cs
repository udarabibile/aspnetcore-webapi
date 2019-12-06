using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using webapi.Models;
using webapi.Repositories;

namespace webapi.Controllers
{
    [ApiController]
    [Route("author")]
    public class AuthorController : ControllerBase
    {
        private IAuthorRepository _authorRepository;

        public AuthorController(IAuthorRepository authorRepository)
            { _authorRepository = authorRepository; }

        [HttpGet("")]
        public IEnumerable<Author> GetAllAuthots() => _authorRepository.GetAll();

        [HttpGet("{authorName}")]
        public Task<Author> GetAuthorByName(String authorName) => _authorRepository.GetByName(authorName);

        [HttpPost("")]
        [AllowAnonymous]
        public void AddAuthor([FromBody] Author author) => _authorRepository.Insert(author);
    }
}