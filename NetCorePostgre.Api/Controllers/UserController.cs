using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCorePostgre.Api.Model.User;

namespace NetCorePostgre.Api.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpGet]
        public string Test()
        {
            return "Your api works. Good job!";

        }

        [HttpPost]
        public Task<IActionResult> Register([FromBody] UserRegisterRequest requestModel)
        {
            return null;
        }
    }
}
