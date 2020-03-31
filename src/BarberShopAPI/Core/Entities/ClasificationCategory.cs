namespace BarberShopAPI.Core.Entities
{
    public class ClasificationCategory
    {
        public int ClasificationID { get; set; }
        public Clasification Clasification { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}