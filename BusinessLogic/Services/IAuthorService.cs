using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Models;

namespace BusinessLogic.Services
{
    public interface IAuthorService
    {
        IEnumerable<Author> GetAllAuthors();
        //Task<Author> GetByName(string firstName);
    }
}
