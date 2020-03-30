using System.Collections.Generic;
using BarberShopAPI.Core.Common;

namespace BarberShopAPI.Core.Entities
{
    public class Clasification : DictionaryEntity
    {
        ICollection<Category> ClasificationCategories { get; set; } = new HashSet<Category>();
    }
}