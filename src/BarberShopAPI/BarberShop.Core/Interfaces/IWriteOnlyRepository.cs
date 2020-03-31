using System;

namespace BarberShop.Core.Interfaces
{
    public interface IWriteOnlyRepository <in T> : IDisposable
    {
        void Create(T newEntity);
        void Delete(T entity);
    }
}