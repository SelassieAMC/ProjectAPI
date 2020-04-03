using BarberShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarberShop.API.Test.TestData
{
    public static class ServicesTestData
    {
        public static List<Service> testPeople =
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
