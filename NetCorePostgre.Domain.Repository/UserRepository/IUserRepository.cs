using NetCorePostgre.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using NetCorePostgre.Domain.Identity;

namespace NetCorePostgre.Domain.Repository.UserRepository
{
    public interface IUserRepository : IBaseRepository<User>
    {
    }
}
