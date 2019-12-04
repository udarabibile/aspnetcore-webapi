using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using webapi.Models;

namespace webapi.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly DatabaseContext context;
        private DbSet<T> entities;
        string errorMessage = string.Empty;
        public Repository(DatabaseContext context)
        {
            this.context = context;
            entities = context.Set<T>(); // TODO BIBI:
        }
        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }
        public T GetById(Guid id)
        {
           return entities.SingleOrDefault(s => s.Id == id); // TODO: GET UID
        }
        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }
        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.SaveChanges();
        }
        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }



        // TODO BIBI: ASYNC REPOSITORY
        public Task<T> FirstOrDefault(Expression<Func<T, bool>> predicate)
            => context.Set<T>().FirstOrDefaultAsync(predicate);



    }
}