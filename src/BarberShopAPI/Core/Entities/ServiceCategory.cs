namespace BarberShopAPI.Core.Entities
{
    public class ServiceCategory
    {
        public int ServiceID { get; set; }
        public Service Service { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}