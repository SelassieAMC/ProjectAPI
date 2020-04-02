using System;

namespace BarberShop.Infraestructure.Interfaces
{
    public interface IRepository<T> : IDisposable, IReadOnlyRepository<T>, IWriteOnlyRepository<T>
    {
        
    }
}