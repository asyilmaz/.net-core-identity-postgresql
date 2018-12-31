using Microsoft.AspNetCore.Identity;
using System;

namespace NetCorePostgre.Domain.Identity
{
    public class UserClaim : IdentityUserClaim<long>
    {
        public DateTime CreatedDate { get; set; }
        public long CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
