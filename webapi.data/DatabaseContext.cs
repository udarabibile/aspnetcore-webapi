using Microsoft.EntityFrameworkCore;
using webapi.core.Models;

namespace webapi.data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Author> authors { get; set; }
        public DbSet<Book> books { get; set; }    

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        { }
    }
}