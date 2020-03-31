using System.Collections.Generic;
using BarberShopAPI.Core.Common;

namespace BarberShopAPI.Core.Entities
{
    public class DocumentType : DictionaryEntity
    {
        public ICollection<Person> DocumentTypePersons { get; set; } = new HashSet<Person>();
    }
}