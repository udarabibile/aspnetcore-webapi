using System.Threading.Tasks;
using webapi.core.Models;

namespace webapi.data.Repositories
{
    public interface IAuthorRepository : IRepository<Author>
    {
        Task<Author> GetByName(string firstName);
    }
}