using System;
using System.Collections.Generic;
using DataAccess.Models;
using DataAccess.Repositories;

namespace BusinessLogic.Services.Impl
{
    public class AuthorService : IAuthorService
    {
        private IUnitOfWork _unitOfWork;

        public AuthorService(IUnitOfWork unitOfWork)
           { _unitOfWork = unitOfWork; }

        public IEnumerable<Author> GetAllAuthors() => _unitOfWork.AuthorRepository.GetAll();
    }
}
