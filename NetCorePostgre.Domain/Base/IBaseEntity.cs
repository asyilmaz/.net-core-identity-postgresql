using System;
using System.Collections.Generic;
using System.Text;

namespace NetCorePostgre.Domain.Base
{
    public interface IBaseEntity
    {
        long Id { get; }
        DateTime CreatedDate { get; set; }
        long CreatedBy { get; set; }
        DateTime? ModifiedDate { get; set; }
        long? ModifiedBy { get; set; }
        bool IsDeleted { get; set; }
    }
}
