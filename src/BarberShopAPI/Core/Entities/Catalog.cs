using BarberShopAPI.Core.Common;

namespace BarberShopAPI.Core.Entities
{
    public class Catalog : DictionaryEntity
    {
        public Clasification Clasification { get; set; }
        public int ClasificationID { get; set; }
        public Employee Employee { get; set; }
        public long EmployeeID { get; set; }
        public bool isEnabled { get; set; }
    }
}