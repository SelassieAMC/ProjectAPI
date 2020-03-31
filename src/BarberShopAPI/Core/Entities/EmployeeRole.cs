namespace BarberShopAPI.Core.Entities
{
    public class EmployeeRole
    {
        public long EmployeeID { get; set; }
        public Employee Employee { get; set; }
        public int RoleID { get; set; }
        public Role Role { get; set; }
    }
}