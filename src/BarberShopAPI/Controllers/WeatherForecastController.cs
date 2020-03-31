using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarberShopAPI.Core.Entities;
using BarberShopAPI.Core.Interfaces;
using BarberShopAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BarberShopAPI.Controllers
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
        private readonly IRepository<DocumentType> _repo;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IRepository<DocumentType> repository)
        {
            _logger = logger;
            _repo = repository;
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
            return _repo.GetAll();
        }
    }
}
