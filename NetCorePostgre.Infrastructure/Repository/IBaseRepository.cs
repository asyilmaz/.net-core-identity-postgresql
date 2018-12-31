using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace NetCorePostgre.Infrastructure.Repository
{
    public interface IBaseRepository<T>
    {
        T GetById(long id);
        ICollection<T> FindAll();
        IQueryable<TResult> Select<TResult>(Expression<Func<T, TResult>> func);
        T Create(T entity);
        T Update(T entity);
        T Remove(T entity);
        T RemoveById(long entityId);
    }
}
