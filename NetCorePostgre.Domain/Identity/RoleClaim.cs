using Microsoft.AspNetCore.Identity;
using NetCorePostgre.Domain.Base;
using System;

namespace NetCorePostgre.Domain.Identity
{
    public class RoleClaim : IdentityRoleClaim<long>
    {
        public DateTime CreatedDate { get; set; }
        public long CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
