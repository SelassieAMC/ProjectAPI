using System;
using System.Linq;

namespace BarberShop.Infraestructure.Interfaces
{
    public interface IReadOnlyRepository<out T> : IDisposable
    {
        IQueryable<T> GetAll();
        T GetById(int id);
    }
}
