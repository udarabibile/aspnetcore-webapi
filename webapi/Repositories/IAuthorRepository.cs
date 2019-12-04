using System.Threading.Tasks;
using webapi.Models;

namespace webapi.Repositories
{
    public interface IAuthorRepository : IRepository<Author>
    {
        Task<Author> GetByFirstName(string firstName);
    }
}