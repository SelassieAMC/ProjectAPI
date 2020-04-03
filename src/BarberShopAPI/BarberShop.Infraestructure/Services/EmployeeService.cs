using BarberShop.Core.Entities;
using BarberShop.Infraestructure.Interfaces;

namespace BarberShop.Infraestructure.Services
{
    public class EmployeeService : GenericRepoService<Employee>
    {
        public readonly IRepository<Employee> _repo;
        public EmployeeService(IRepository<Employee> repo) : base(repo)
        {
            _repo = repo;
        }
    }
}