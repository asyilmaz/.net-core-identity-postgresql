using System;

namespace NetCorePostgre.Application.Model
{
    public class ApiResult
    {
        public bool IsSucceeded { get; set; }
        public object Data { get; set; }
        public Error Error { get; set; }
    }
}
