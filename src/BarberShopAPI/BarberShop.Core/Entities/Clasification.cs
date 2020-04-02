using System.Collections.Generic;
using BarberShop.Core.Common;

namespace BarberShop.Core.Entities
{
    public class Clasification : DictionaryEntity
    {
        public ICollection<ClasificationCategory> ClasificationCategories { get; set; } = new HashSet<ClasificationCategory>();
        public ICollection<Catalog> ClasificationCatalogs { get; set; } = new HashSet<Catalog>();
    }
}