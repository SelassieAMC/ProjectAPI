using System.Collections.Generic;
using BarberShopAPI.Core.Common;

namespace BarberShopAPI.Core.Entities
{
    public class Category :DictionaryEntity
    {
        public ICollection<ServiceCategory> CategoryServices { get; set; } = new HashSet<ServiceCategory>();
        public ICollection<ClasificationCategory> CategoryClasifications { get; set; } = new HashSet<ClasificationCategory>();
    }
}