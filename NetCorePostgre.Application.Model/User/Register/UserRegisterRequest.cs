using System;
using System.Collections.Generic;
using System.Text;

namespace NetCorePostgre.Application.Model
{
    public class UserRegisterRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
