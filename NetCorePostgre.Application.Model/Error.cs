using System;
using System.Collections.Generic;
using System.Text;

namespace NetCorePostgre.Application.Model
{
    public class Error
    {
        public int Code { get; set; }
        public string Message { get; set; }
    }
}
