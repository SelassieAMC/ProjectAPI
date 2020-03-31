using System.Collections.Generic;
using System.Linq;
using BarberShop.Core.Interfaces;
using BarberShop.Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BarberShop.Infraestructure.Services
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly BarberShopContext _context;
        private readonly DbSet<T> _set;

        public Repository(BarberShopContext context)
        {
            _context = context;
            _set = _context.Set<T>();
        }

        public void Create(T newEntity)
        {
            _set.Add(newEntity);
        }

        public void Delete(T entity)
        {
            _set.Remove(entity);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IQueryable<T> GetAll()
        {
            return _set;
        }

        public T GetById(int id)
        {
            return _set.Find(id);
        }
    }
}