using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using webapi.core.Models;

namespace webapi.business.Services
{
    public interface IAuthorService
    {
        IEnumerable<Author> GetAllAuthors();
        //Task<Author> GetByName(string firstName);
    }
}
