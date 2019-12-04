using System.Threading.Tasks;
using webapi.Models;

namespace webapi.Repositories
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(DatabaseContext context) : base(context) { }

        public Task<Author> GetByFirstName(string name)
        {
            return FirstOrDefault(w => w.Name == name);
        }
    }
}