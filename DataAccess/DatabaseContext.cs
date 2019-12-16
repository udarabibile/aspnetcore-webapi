using Microsoft.EntityFrameworkCore;
using DataAccess.Models;

namespace DataAccess
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Author> authors { get; set; }
        public DbSet<Book> books { get; set; }    

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        { }
    }
}