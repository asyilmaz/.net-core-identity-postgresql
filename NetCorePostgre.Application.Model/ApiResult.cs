using System;
using System.Collections.Generic;

namespace NetCorePostgre.Application.Model
{
    public class Result
    {
        public bool Succeeded { get; set; }
        public object Data { get; set; }
        public List<Error> Errors { get; set; } = new List<Error>();
    }
}
