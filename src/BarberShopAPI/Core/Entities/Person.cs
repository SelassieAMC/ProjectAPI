using System;
using BarberShopAPI.Core.Common;

namespace BarberShopAPI.Core.Entities
{
    public class Person : AuditableEntity
    {
        public long Id { get; set; }
        public int DocumentTypeID { get; set; }
        public DocumentType DocumentType { get; set; }
        public string IdNum { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string SeconLastName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Gender { get; set; }
        public string PhotoFile { get; set; }
        public string Phone { get; set; }
    }
}