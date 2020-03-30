using BarberShopAPI.Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BarberShopAPI.Extensions.DependencyInjection
{
    public static class Services
    {
        public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration){
            services.AddDbContext<BarberShopContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("BarberShopDatabase")));
            return services;
        }
    }
}