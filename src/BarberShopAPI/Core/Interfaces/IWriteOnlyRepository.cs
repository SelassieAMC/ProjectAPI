using System;

namespace BarberShopAPI.Core.Interfaces
{
    public interface IWriteOnlyRepository <in T> : IDisposable
    {
        void Create(T newEntity);
        void Delete(T entity);
    }
}