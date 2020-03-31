namespace BarberShopAPI.Core.Entities
{
    public class EmployeeSubordinate
    {
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
        public int subordinateID { get; set; }
        public Employee Subordinate { get; set; }
    }
}