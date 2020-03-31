using System.Collections.Generic;
using BarberShopAPI.Core.Common;

namespace BarberShopAPI.Core.Entities
{
    public class Clasification : DictionaryEntity
    {
        public ICollection<ClasificationCategory> ClasificationCategories { get; set; } = new HashSet<ClasificationCategory>();
        public ICollection<Catalog> ClasificationCatalogs { get; set; } = new HashSet<Catalog>();
    }
}