using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset.Domain.Seeds
{
    public abstract class BaseAuditModel
    {
        public Guid Guid { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedbyUserGuid { get; set; }
        public Guid LastModifiedByUserGuid { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
