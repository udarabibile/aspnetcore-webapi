using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess.Repositories
{
    public interface IAuthorRepository : IRepository<Author>
    {
        Task<Author> GetByName(string firstName);
    }
}