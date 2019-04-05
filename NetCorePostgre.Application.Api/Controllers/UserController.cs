using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NetCorePostgre.Application.Service;
using NetCorePostgre.Application.Model;

namespace NetCorePostgre.Application.Api.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public string Test()
        {
            return "Your api works. Good job!";
        }

        [HttpPost]
        public async Task<JsonResult> Register([FromBody] UserRegisterRequest model)
        {
            if (ModelState.IsValid)
            {
                var response = await _userService.CreateUser(model);
                return new JsonResult(response);
            }
            else { return new JsonResult(BadRequest()); }


        }

        [HttpPost]
        public async Task<JsonResult> Login([FromBody] UserLoginRequest model)
        {
            if (ModelState.IsValid)
            {
                var response = await _userService.Login(model);
                return new JsonResult(response);
            }
            else { return new JsonResult(BadRequest()); }


        }
    }
}
