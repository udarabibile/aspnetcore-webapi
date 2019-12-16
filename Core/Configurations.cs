using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

using DataAccess;
using BusinessLogic.Services;
using BusinessLogic.Services.Impl;
using DataAccess.Repositories;
using DataAccess.Repositories.Impl;

namespace Core
{
    public class Configurations
    {
        public Configurations()
        {
        }

        public static void configureDependencies(IServiceCollection services)
        {
            services.AddDbContext<DatabaseContext>(opts => opts.UseInMemoryDatabase("database"));
            services.AddScoped<DatabaseContext>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
