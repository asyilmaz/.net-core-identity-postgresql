using System;
using System.Collections.Generic;
using System.Text;

namespace NetCorePostgre.Infrastructure.Entity
{
    public class BaseEntity : IBaseEntity
    {
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
