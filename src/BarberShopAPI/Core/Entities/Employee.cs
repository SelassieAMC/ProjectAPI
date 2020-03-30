using System;
using System.Collections.Generic;
using BarberShopAPI.Core.Common;

namespace BarberShopAPI.Core.Entities
{
    public class Employee : AuditableEntity
    {
        public Employee()
        {
            Subordinates = new HashSet<Employee>();
            QualifiedServices = new HashSet<Service>();
        }
        public long Id { get; set; }
        public DateTime? LastService { get; set; }
        public int PersonID { get; set; }
        public Person Person { get; set; }
        public ICollection<Employee> Subordinates { get; set; }
        public ICollection<Service> QualifiedServices {get; set; }        
    }
}