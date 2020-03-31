using System;

namespace BarberShop.Core.Interfaces
{
    public interface IRepository<T> : IDisposable, IReadOnlyRepository<T>, IWriteOnlyRepository<T>
    {
        
    }
}