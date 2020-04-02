using System.Collections.Generic;
using BarberShop.Core.Common;

namespace BarberShop.Core.Entities
{
    public class Service : DictionaryEntity
    {
        public Service()
        {
            ServiceCategories = new HashSet<ServiceCategory>();
            QualifiedEmployees = new HashSet<ServiceEmployee>();
        }
        public float TimeSpend { get; set; }
        public int Price { get; set; }
        public ICollection<ServiceCategory> ServiceCategories { get; set; }
        public ICollection<ServiceEmployee> QualifiedEmployees {get; set; }  
    }
}