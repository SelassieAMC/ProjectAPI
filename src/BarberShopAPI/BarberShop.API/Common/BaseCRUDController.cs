using BarberShop.Infraestructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BarberShopAPI.Common
{
    public abstract class BaseCRUDController<T> : ControllerBase
    {
        private readonly IRepository<T> _repo;

        public BaseCRUDController(IRepository<T> repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public virtual IEnumerable<T> GetAll()
        {
            return _repo.GetAll();
        }
        [HttpGet]
        public virtual T GetById(int id)
        {
            return _repo.GetById(id);
        }
        [HttpPost]
        public virtual T Create(T entity)
        {
            _repo.Create(entity);
            return GetById((int)typeof(T).GetProperty("Id").GetValue(entity, null));
        }
        [HttpDelete]
        public virtual void Detele(T entity)
        {
            _repo.Delete(entity);
        }
    }
}