namespace BarberShopAPI.Core.Common
{
    public class DictionaryEntity : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Description { get; set; }
    }
}