using System.Collections.Generic;
using BarberShopAPI.Core.Common;

namespace BarberShopAPI.Core.Entities
{
    public class Category :DictionaryEntity
    {
        public ICollection<Service> CategoryServices { get; set; } = new HashSet<Service>();
        public ICollection<Clasification> CategoryClasifications { get; set; } = new HashSet<Clasification>();
    }
}