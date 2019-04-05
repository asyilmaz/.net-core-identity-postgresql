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

    }
}
