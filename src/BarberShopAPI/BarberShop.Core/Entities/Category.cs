using System.Collections.Generic;
using BarberShop.Core.Common;

namespace BarberShop.Core.Entities
{
    public class Category :DictionaryEntity
    {
        public ICollection<ServiceCategory> CategoryServices { get; set; } = new HashSet<ServiceCategory>();
        public ICollection<ClasificationCategory> CategoryClasifications { get; set; } = new HashSet<ClasificationCategory>();
    }
}