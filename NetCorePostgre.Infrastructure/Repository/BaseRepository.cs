using NetCorePostgre.Infrastructure.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace NetCorePostgre.Infrastructure.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IBaseEntity
    {
        private readonly PostgreSqlDbContext _dbContext;
        public BaseRepository(PostgreSqlDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public T FindById(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public virtual ICollection<T> FindAll()
        {
            return _dbContext.Set<T>().OrderBy(e => e.Id).ToList();
        }

        public IQueryable<TResult> Select<TResult>(Expression<Func<T, TResult>> func)
        {
            return _dbContext.Set<T>().Select(func);
        }

        public T Create(T entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public T Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public T Remove(T entity)
        {
            entity.IsDeleted = true;
            _dbContext.Update(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public T RemoveById(int entityId)
        {
             var entity = FindById(entityId);
            entity.IsDeleted = true;
            _dbContext.Update(entity);
            _dbContext.SaveChanges();
            return entity;
        }
    }
}
