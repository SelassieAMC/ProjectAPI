using System.Collections.Generic;
using BarberShopAPI.Core.Common;

namespace BarberShopAPI.Core.Entities
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