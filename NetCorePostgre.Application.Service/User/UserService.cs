using Microsoft.AspNetCore.Identity;
using NetCorePostgre.Domain.Identity;
using NetCorePostgre.Domain.Repository.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NetCorePostgre.Application.Service.User
{
    public class UserService : IUserService
    {
        private readonly UserManager<NetCorePostgre.Domain.Identity.User> _userManager;
        private readonly UserRepository _UserRepository;

        //public UserService(IUserRepository)
        //{

        //}



        //public async Task<User> Register()
        //{

        //    return null;
        //}
    }
}
