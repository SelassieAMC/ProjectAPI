using System;

namespace BarberShopAPI.Core.Interfaces
{
    public interface IRepository<T> : IDisposable, IReadOnlyRepository<T>, IWriteOnlyRepository<T>
    {
        
    }
}