using BarberShopAPI.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BarberShopAPI.Infraestructure.Persistence
{
    public class BarberShopContext : DbContext
    {
        public BarberShopContext(DbContextOptions<BarberShopContext> options) :base(options)
        {        
        }

        DbSet<Catalog> catalogs;
        DbSet<CatalogMedia> CatalogsMedia;
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}