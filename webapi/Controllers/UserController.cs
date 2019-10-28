using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webapi.Models;

namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly UserDbContext _context;

        public UserController(ILogger<UserController> logger, UserDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<User> users = _context.getUsers();
            return Ok(users);
        }


        [HttpGet]
        [Route("/random")]
        public IEnumerable<User> Get()
        {
            var rng = new Random();
            return Enumerable.Range(0 , 2).Select(index => new User
            {
                DateOfBirth = DateTime.Now.AddDays(index),
                FirstName = RandomNames[index]
            })
            .ToArray();
        }

        private static readonly string[] RandomNames = {
            "John", "Bill", "Jack"
        };
    }
}
