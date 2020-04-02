using System.Collections.Generic;
using BarberShop.Core.Common;

namespace BarberShop.Core.Entities
{
    public class DocumentType : DictionaryEntity
    {
        public ICollection<Person> DocumentTypePersons { get; set; } = new HashSet<Person>();
    }
}