using System;

namespace BarberShop.Infraestructure.Interfaces
{
    public interface IWriteOnlyRepository <in T> : IDisposable
    {
        void Create(T newEntity);
        void Delete(T entity);
    }
}