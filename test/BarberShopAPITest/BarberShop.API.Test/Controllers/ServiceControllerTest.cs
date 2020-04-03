using BarberShop.API.Test.Mockings;
using BarberShop.API.Test.TestData;
using BarberShop.Core.Entities;
using BarberShop.Infraestructure.Interfaces;
using BarberShopAPI.Controllers;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace BarberShop.API.Test.Controllers
{
    public class ServiceControllerTest
    {
        private IRepository<Service> GetTestRepository(int id=0)
        {
            List<Service> testServices = ServicesTestData.testPeople;
            var mockRepo = new Mock<IRepository<Service>>();
            mockRepo.Setup(r => r.GetAll()).Returns(testServices.AsQueryable());
            mockRepo.Setup(r => r.GetById(id)).Returns(testServices.Where(x => x.Id == id).SingleOrDefault());
            return mockRepo.Object;
        }
        [Fact]
        public void ServiceItems_GetAll()
        {
            //Arrange
            var fakeRepo = GetTestRepository();
            var serviceController = new ServiceController(fakeRepo);

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
            var fakeRepo = GetTestRepository(2);
            var serviceController = new ServiceController(fakeRepo);

            //Act
            var service = serviceController.GetById(2);

            //Assert
            Assert.NotNull(service);
            Assert.Equal("Manicure", service.Name);
        }
    }
}
