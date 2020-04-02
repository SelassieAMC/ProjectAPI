using BarberShop.Core.Entities;
using BarberShop.Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BarberShop.API.Test.Mockings
{
    public class FakeServiceRepository : IRepository<Service>
    {
        public static IEnumerable<Service> services { get; set; }
        public IQueryable<Service> GetAll()
        {
            return services.AsQueryable();
        }

        public Service GetById(int id)
        {
            return services.First(x => x.Id == id);
        }

        public void Create(Service newEntity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Service entity)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}