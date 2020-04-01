using System.Linq;
using BarberShop.Core.Interfaces;

namespace BarberShop.Infraestructure.Services
{
    public abstract class GenericService<T>
    {
        private readonly IRepository<T> _repo;

        public GenericService(IRepository<T> repo)
        {
            _repo = repo;
        }

        public virtual IQueryable<T> GetAll() {
            return _repo.GetAll();
        }

        public virtual T FindById(int id) {
            return _repo.GetById(id);
        }

        public virtual T Create(T entity) {
            _repo.Create(entity);
            return FindById((int)typeof(T).GetProperty("Id").GetValue(entity, null));
        }

        public virtual void Detele(T entity) {
            _repo.Delete(entity);
        }
    }
}