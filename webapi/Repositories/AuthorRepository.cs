using webapi.Models;

namespace webapi.Repositories
{
    public class AccountRepository : Repository<Author>, IAuthorRepository
    {
        public AccountRepository(DatabaseContext databaseContext)
            : base(databaseContext)
        {
        }
    }
}