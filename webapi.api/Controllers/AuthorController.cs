using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using webapi.core.Models;
using webapi.business.Services;

namespace webapi.api.Controllers
{
    [ApiController]
    [Route("author")]
    public class AuthorController : ControllerBase
    {
        private IAuthorService authorService;

        public AuthorController(IAuthorService authorService)
            { this.authorService = authorService; }

        [HttpGet("")]
        public IEnumerable<Author> GetAllAuthors() =>
            authorService.GetAllAuthors();

        [HttpGet("{authorName}")]
        public Task<Author> GetAuthorByName(String authorName) =>
            authorService.GetAuthorByName(authorName);

        [HttpPost("")]
        [AllowAnonymous]
        public void AddAuthor([FromBody] Author author) =>
            authorService.CreateAuthor(author);
    }
}