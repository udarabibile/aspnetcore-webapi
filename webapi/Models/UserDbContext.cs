using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace webapi.Models
{
    public class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
            LoadDefaultUsers();
        }

        public List<User> getUsers()
        {
            return Users.Local.ToList<User>();
        }

        private void LoadDefaultUsers()
        {
            Users.Add(new User());
            Users.Add(new User());
        }

        // public UserDbContext() { }
    }
}
