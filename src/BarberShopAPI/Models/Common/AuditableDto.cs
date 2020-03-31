using System;

namespace BarberShopAPI.Models.Common
{
    public abstract class AuditableDto
    {
        public string CreatedBy { get; set; }

        public DateTime Created { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTime? LastModified { get; set; }
    }
}
