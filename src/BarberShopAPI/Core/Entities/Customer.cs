using System;
using BarberShopAPI.Core.Common;

namespace BarberShopAPI.Core.Entities
{
    public class Customer : AuditableEntity
    {
        public int customerID { get; set; }
        public DateTime? LastVisit { get; set; }
        public bool IsVIP { get; set; }
        public long PersonID { get; set; }
        public Person Person { get; set; }
    }
}