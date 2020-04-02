using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarberShop.Core.Entities;
using BarberShop.Infraestructure.Interfaces;
using BarberShop.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BarberShopAPI;

namespace BarberShop.API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IRepository<DocumentType> _docRepo;
        private readonly IRepository<Service> _servRepo;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger, 
            IRepository<DocumentType> repository,
            IRepository<Service> repoService)
        {
            _logger = logger;
            _docRepo = repository;
            _servRepo = repoService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet]
        public IEnumerable<DocumentType> GetDocumentTypes()
        {
            return _docRepo.GetAll();
        }

        [HttpGet]
        public IEnumerable<Service> GetServices()
        {
            return _servRepo.GetAll();
        }
    }
}
