namespace BarberShop.Core.Entities
{
    public class ServiceEmployee
    {
        public int ServiceID { get; set; }
        public Service Service { get; set; }
        public long EmployeeID { get; set; }
        public Employee Employee { get; set; }
    }
}