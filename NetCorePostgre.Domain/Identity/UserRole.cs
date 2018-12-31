using Microsoft.AspNetCore.Identity;
using System;

namespace NetCorePostgre.Domain.Identity
{
    public class UserRole : IdentityUserRole<long>
    {
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
