using System.Collections.Generic;
using BarberShopAPI.Core.Common;

namespace BarberShopAPI.Core.Entities
{
    public class Service : DictionaryEntity
    {
        public Service()
        {
            ServiceCategories = new HashSet<Category>();
            QualifiedEmployees = new HashSet<Employee>();
        }
        public float TimeSpend { get; set; }
        public int Price { get; set; }
        public ICollection<Category> ServiceCategories { get; set; }
        public ICollection<Employee> QualifiedEmployees {get; set; }  
    }
}