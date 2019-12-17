// using System;
// using System.Collections.Generic;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Logging;
// using webapi.core.Models;
// using DataAccess.Repositories;

// namespace webapi.Controllers
// {
//     [ApiController]
//     [Route("uow")]
//     public class UoWConrtroller : ControllerBase
//     {
//         private readonly ILogger<UoWConrtroller> _logger;
//         private IUnitOfWork _unitOfWork;

//         public UoWConrtroller(ILogger<UoWConrtroller> logger, IUnitOfWork unitOfWork)
//         {
//             _logger = logger;
//             _unitOfWork = unitOfWork;
//         }

//         [HttpGet("")]
//         public Task<Author> CommitUoW()
//         {
//             Book gambler = new Book("The Gambler");
//             Author fyodor = new Author("Fyodor Dostoyevsky", "Russia", new List<Book>() { gambler });

//             try
//             {
//                 _unitOfWork.BookRepository.Insert(gambler);
//                 _unitOfWork.AuthorRepository.Insert(fyodor);
//                 _unitOfWork.Commit();
//             }
//             catch (Exception ex)
//             {
//                 _logger.LogError("Error when creating uow transaction, thereby reverting back. Error: {}", ex.Message);
//                 _unitOfWork.Rollback();
//                 return Task.FromResult(new Author());
//             }

//             return _unitOfWork.AuthorRepository.GetByName(fyodor.Name);
//         }
//     }
// }