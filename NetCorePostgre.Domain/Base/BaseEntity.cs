using System;
using System.Collections.Generic;
using System.Text;

namespace NetCorePostgre.Domain.Base
{
    public class BaseEntity
    {
        public long Id { get; }
        public DateTime CreatedDate { get; set; }
        public long CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
