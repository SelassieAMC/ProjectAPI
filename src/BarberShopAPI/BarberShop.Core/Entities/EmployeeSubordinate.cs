namespace BarberShop.Core.Entities
{
    public class EmployeeSubordinate
    {
        public long EmployeeID { get; set; }
        public Employee Employee { get; set; }
        public long subordinateID { get; set; }
        public Employee Subordinate { get; set; }
    }
}