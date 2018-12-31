using Microsoft.AspNetCore.Identity;
using NetCorePostgre.Application.Model;
using NetCorePostgre.Domain.Identity;
using System;

namespace NetCorePostgre.Application.Business
{
    public class UserBusiness
    {
        private readonly UserManager<User> _userManager;

        public UserBusiness(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public ApiResult CreateUser(UserRegisterRequest requestModel)
        {
            ApiResult result = new ApiResult();
            
            User user = new User()
            {
                Email = requestModel.Email
            };
            _userManager.PasswordHasher.HashPassword(user, requestModel.Password);

            _userManager.CreateAsync(user);

            result.Data = user;
            result.IsSucceeded = true;
            return result;

        }
    }
}
