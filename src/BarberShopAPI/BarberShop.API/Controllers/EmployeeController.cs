using BarberShop.Core.Entities;
using BarberShop.Infraestructure.Interfaces;
using BarberShopAPI.Common;
using Microsoft.AspNetCore.Mvc;

namespace BarberShopAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : BaseCRUDController<Employee>
    {
        private readonly IRepository<Employee> _repo;

        public EmployeeController(IRepository<Employee> employRepo) : base(employRepo)
        {
            _repo = employRepo;
        }


    }
}