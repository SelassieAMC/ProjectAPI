using Microsoft.EntityFrameworkCore;
using BarberShop.Infraestructure.Persistence;
using BarberShop.Infraestructure.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using BarberShop.Core.Entities;
using BarberShop.Core.Interfaces;

namespace BarberShop.Infraestructure.DependencyInjection
{
    public static class Services
    {
        public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration){
            services.AddDbContext<BarberShopContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("BarberShopDatabase"), 
                b => b.MigrationsAssembly(typeof(BarberShopContext).Assembly.FullName)));
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository<DocumentType>, Repository<DocumentType>>();
            return services;
        }
    }
}