using BarberShop.Core.Entities;
using System;
using System.Collections.Generic;

namespace BarberShop.API.Test.Mockings
{
    public class BaseTest
    {
        //IRepository<Service> fake = new FakeServiceRepository();
        public BaseTest()
        {
            PopulateInitalData();
        }

        private void PopulateInitalData()
        {
            FakeServiceRepository.services = 
                new List<Service>(){
                    new Service() {
                        Id = 1,
                        Created = DateTime.Now,
                        CreatedBy = "aclavijo",
                        Description = "Peinado de cabello y tratamiento.",
                        Name = "Cepillado",
                        Price = 40000,
                        TimeSpend = 2
                    },
                    new Service() {
                        Id = 2,
                        Created = DateTime.Now,
                        CreatedBy = "aclavijo",
                        Description = "Limpieza de uñas y pintado.",
                        Name = "Manicure",
                        Price = 10000,
                        TimeSpend = 1
                    }
                };
        }
    }
}
