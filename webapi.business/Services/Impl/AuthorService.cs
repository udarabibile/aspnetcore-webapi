using System;
using System.Collections.Generic;
using webapi.domain.Models;
using webapi.data.Repositories;

namespace webapi.business.Services.Impl
{
    public class AuthorService : IAuthorService
    {
        private IUnitOfWork _unitOfWork;

        public AuthorService(IUnitOfWork unitOfWork)
           { _unitOfWork = unitOfWork; }

        public IEnumerable<Author> GetAllAuthors() => _unitOfWork.AuthorRepository.GetAll();
    }
}
