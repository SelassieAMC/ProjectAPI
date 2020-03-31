namespace BarberShopAPI.Core.Entities
{
    public class EmployeeRole
    {
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
        public int RoleID { get; set; }
        public Role Role { get; set; }
    }
}