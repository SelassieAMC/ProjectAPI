using System;
using BarberShop.Core.Common;

namespace BarberShop.Core.Entities
{
    public class EmployeeAvailability : AuditableEntity
    {
        public int Id { get; set; }        
        public long EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public DateTimeOffset DateTime { get; set; }
        public bool AllDay { get; set; }
        public bool IsAvailable { get; set; }
    }
}