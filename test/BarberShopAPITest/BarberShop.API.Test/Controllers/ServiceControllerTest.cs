using BarberShop.API.Test.Mockings;
using BarberShop.Core.Entities;
using BarberShop.Infraestructure.Interfaces;
using BarberShopAPI.Controllers;
using System;
using System.Linq;
using Xunit;

namespace BarberShop.API.Test.Controllers
{
    public class ServiceControllerTest : BaseTest
    {
        IRepository<Service> fake = new FakeServiceRepository();
        [Fact]
        public void ServiceItems_GetAll()
        {
            //Arrange
            var serviceController = new ServiceController(fake);

            //Act
            var services = serviceController.GetAll().ToList();

            //Assert
            Assert.NotNull(services);
            Assert.Equal(2, services.Count);
        }

        [Fact]
        public void ServiceItems_GetById()
        {
            //Arrange
            var serviceController = new ServiceController(fake);

            //Act
            var service = serviceController.GetById(2);

            //Assert
            Assert.NotNull(service);
            Assert.Equal("Manicure", service.Name);
        }
    }
}
