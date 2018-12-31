using NetCorePostgre.Domain.Identity;
using NetCorePostgre.Infrastructure;
using NetCorePostgre.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCorePostgre.Domain.Repository.UserRepository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(PostgreSqlDbContext dbContext)
            :base(dbContext)
        {

        }
        public User Create(User entity)
        {
            return this.Create(entity);
        }

        public ICollection<User> FindAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(long id)
        {
            throw new NotImplementedException();
        }

        public User Remove(User entity)
        {
            throw new NotImplementedException();
        }

        public User RemoveById(long entityId)
        {
            throw new NotImplementedException();
        }

        public System.Linq.IQueryable<TResult> Select<TResult>(System.Linq.Expressions.Expression<Func<User, TResult>> func)
        {
            throw new NotImplementedException();
        }

        public User Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
