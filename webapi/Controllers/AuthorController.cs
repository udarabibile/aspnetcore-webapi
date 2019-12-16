using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using DataAccess.Models;// ???
using BusinessLogic.Services;

namespace webapi.Controllers
{
    [ApiController]
    [Route("author")]
    public class AuthorController : ControllerBase
    {
        private IAuthorService authorService;

        public AuthorController(IAuthorService authorService)
            { this.authorService = authorService; }

        [HttpGet("")]
        public IEnumerable<Author> GetAllAuthots() => authorService.GetAllAuthors();

        //[HttpGet("{authorName}")]
        //public Task<Author> GetAuthorByName(String authorName) => authorService.GetByName(authorName);

        //[HttpPost("")]
        //[AllowAnonymous]
        //public void AddAuthor([FromBody] Author author) => _authorRepository.Insert(author);
    }
}