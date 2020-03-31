using System;
using BarberShop.Core.Common;

namespace BarberShop.Core.Entities
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