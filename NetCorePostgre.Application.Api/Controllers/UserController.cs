using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NetCorePostgre.Application.Business;
using NetCorePostgre.Application.Model;

namespace NetCorePostgre.Application.Api.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserBusiness _userBusiness;

        public UserController(UserBusiness userBusiness)
        {
            _userBusiness = userBusiness;
        }

        [HttpGet]
        public string Test()
        {
            return "Your api works. Good job!";
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] UserRegisterRequest model)
        {
            if (model == null) return BadRequest();
            _userBusiness.CreateUser(model);

            return null;
        }
    }
}
