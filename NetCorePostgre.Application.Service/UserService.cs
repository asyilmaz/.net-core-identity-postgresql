using Microsoft.AspNetCore.Identity;
using NetCorePostgre.Application.Model;
using NetCorePostgre.Domain.Identity;
using System;
using System.Threading.Tasks;

namespace NetCorePostgre.Application.Service
{
    public class UserService
    {
        private readonly UserManager<User> _userManager;

        public UserService(UserManager<User> userManager)
        {
            _userManager = userManager; 
        }
        public async Task<Result> CreateUser(UserRegisterRequest requestModel)
        {
            Result result = new Result();

            User user = new User()
            {
                EmailConfirmed = false,
                AccessFailedCount = 0,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                Email = requestModel.Email,
                UserName = requestModel.Email
            };


            IdentityResult identityResult = await _userManager.CreateAsync(user, requestModel.Password);
            if (identityResult.Succeeded == false)
            {
                result.Succeeded = false;
                foreach (var error in identityResult.Errors)
                {
                    result.Errors.Add(new Error()
                    {
                        Code = error.Code,
                        Message = error.Description
                    });
                }
            }
            else
            {
                result.Data = user;
                result.Succeeded = true;
            }

            return result; 

        }

        public async Task<Result> Login(UserLoginRequest requestModel)
        {
            return null;
        } 
    }
}
 