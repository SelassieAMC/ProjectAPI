namespace BarberShopAPI.Core.Entities
{
    public class ServiceEmployee
    {
        public int ServiceID { get; set; }
        public Service Service { get; set; }
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
    }
}