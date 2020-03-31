using System;
using System.Collections.Generic;
using BarberShopAPI.Core.Common;

namespace BarberShopAPI.Core.Entities
{
    public class Employee : AuditableEntity
    {
        public Employee()
        {
            Subordinates = new HashSet<EmployeeSubordinate>();
            QualifiedServices = new HashSet<ServiceEmployee>();
            EmployeeRoles = new HashSet<EmployeeRole>();
        }
        public long Id { get; set; }
        public DateTime? LastService { get; set; }
        public int PersonID { get; set; }
        public Person Person { get; set; }
        public ICollection<EmployeeSubordinate> Subordinates { get; set; }
        public ICollection<ServiceEmployee> QualifiedServices {get; set; }     
        public ICollection<EmployeeRole> EmployeeRoles { get; set; }
        public ICollection<Catalog> EmployeeCatalogs { get; set; } = new HashSet<Catalog>();
    }
}