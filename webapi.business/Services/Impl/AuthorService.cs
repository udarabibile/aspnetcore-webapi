using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using webapi.core.Models;
using webapi.data.Repositories;

namespace webapi.business.Services.Impl
{
    public class AuthorService : IAuthorService
    {
        private IUnitOfWork _unitOfWork;

        public AuthorService(IUnitOfWork unitOfWork)
           { _unitOfWork = unitOfWork; }

        public IEnumerable<Author> GetAllAuthors() => _unitOfWork.AuthorRepository.GetAll();
        public Task<Author> GetAuthorByName(string firstName) => _unitOfWork.AuthorRepository.GetByName(firstName);
        public void CreateAuthor(Author author) => _unitOfWork.AuthorRepository.Insert(author);
    }
}
