using System.Threading.Tasks;
using webapi.domain.Models;

namespace webapi.data.Repositories
{
    public interface IAuthorRepository : IRepository<Author>
    {
        Task<Author> GetByName(string firstName);
    }
}