using System.Collections.Generic;
using BarberShop.Core.Common;

namespace BarberShop.Core.Entities
{
    public class Role : DictionaryEntity
    {
        public Role()
        {
            RolesEmployee = new HashSet<EmployeeRole>();
        }
        public ICollection<EmployeeRole> RolesEmployee { get; set; }
    }
}