using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarberShop.Core.Entities;
using BarberShop.Infraestructure.Interfaces;
using BarberShopAPI.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BarberShopAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ServiceController : BaseCRUDController<Service>
    {
        private readonly IRepository<Service> _repo;
        public ServiceController(IRepository<Service> serviceRepo) : base(serviceRepo)
        {
            _repo = serviceRepo;
        }
    }
}